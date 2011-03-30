﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace VGMToolbox.util
{
    public sealed class FileUtil
    {
        private FileUtil() { }

        /// <summary>
        /// Reads data into a complete array, throwing an EndOfStreamException
        /// if the stream runs out of data first, or if an IOException
        /// naturally occurs.
        /// </summary>
        /// <param name="stream">The stream to read data from</param>
        /// <param name="data">The array to read bytes into. The array
        /// will be completely filled from the stream, so an appropriate
        /// size must be given.</param>
        public static void ReadWholeArray(Stream stream, byte[] data)
        {
            ReadWholeArray(stream, data, data.Length);
        }

        public static void ReadWholeArray(Stream stream, byte[] data, int pLength)
        {
            int offset = 0;
            int remaining = pLength;
            while (remaining > 0)
            {
                int read = stream.Read(data, offset, remaining);
                if (read <= 0)
                {
                    throw new EndOfStreamException(
                        String.Format(CultureInfo.CurrentCulture, "End of stream reached with {0} bytes left to read", remaining));
                }
                
                remaining -= read;
                offset += read;
            }
        }
        
        /// <summary>
        /// Replaces 0x00 with 0x20 in an array of bytes.
        /// </summary>
        /// <param name="value">Array of bytes to alter.</param>
        /// <returns>Original array with 0x00 replaced by 0x20.</returns>
        public static byte[] ReplaceNullByteWithSpace(byte[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == 0x00)
                {
                    value[i] = 0x20;
                }
            }

            return value;
        }

        /// <summary>
        /// Returns the count of files contained in the input directories and their subdirectories.
        /// </summary>
        /// <param name="paths">Paths to count files within.</param>
        /// <returns>Number of files in the incoming directories and their subdirectories.</returns>
        public static int GetFileCount(string[] paths)
        { 
            return GetFileCount(paths, true);
        }

        public static int GetFileCount(string[] paths, bool includeSubdirs)
        {
            int totalFileCount = 0;
            
            foreach (string path in paths)
            {
                if (File.Exists(path))
                {
                    totalFileCount++;
                }
                else if (Directory.Exists(path))
                {
                    if (includeSubdirs)
                    {
                        totalFileCount += Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Length;
                    }
                    else
                    {
                        totalFileCount += Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly).Length;
                    }
                }
            }

            return totalFileCount;
        }

        public static string CleanFileName(string pDirtyFileName)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                pDirtyFileName = pDirtyFileName.Replace(c, '_');
            }

            return pDirtyFileName;
        }

        public static void UpdateTextField(
            string pFilePath, 
            string pFieldValue, 
            int pOffset,
            int pMaxLength)
        {
            System.Text.Encoding enc = System.Text.Encoding.ASCII;

            using (BinaryWriter bw =
                new BinaryWriter(File.Open(pFilePath, FileMode.Open, FileAccess.ReadWrite)))
            {
                byte[] newBytes = new byte[pMaxLength];
                byte[] convertedBytes = enc.GetBytes(pFieldValue);

                int numBytesToCopy =
                    convertedBytes.Length <= pMaxLength ? convertedBytes.Length : pMaxLength;
                Array.ConstrainedCopy(convertedBytes, 0, newBytes, 0, numBytesToCopy);

                bw.Seek(pOffset, SeekOrigin.Begin);
                bw.Write(newBytes);
            }
        }

        public static void UpdateChunk(
            string pFilePath,
            int pOffset,
            byte[] value)
        {
            using (BinaryWriter bw =
                new BinaryWriter(File.Open(pFilePath, FileMode.Open, FileAccess.ReadWrite)))
            {
                bw.Seek(pOffset, SeekOrigin.Begin);
                bw.Write(value);
            }
        }

        public static void ReplaceFileChunk(
            string pSourceFilePath, 
            long pSourceOffset,
            long pLength, 
            string pDestinationFilePath, 
            long pDestinationOffset)
        {
            int read = 0;
            long maxread;
            int totalBytes = 0;
            byte[] bytes = new byte[Constants.FileReadChunkSize];

            using (BinaryWriter bw =
                new BinaryWriter(File.Open(pDestinationFilePath, FileMode.Open, FileAccess.ReadWrite)))
            {
                using (BinaryReader br =
                    new BinaryReader(File.Open(pSourceFilePath, FileMode.Open, FileAccess.Read)))
                {
                    br.BaseStream.Position = pSourceOffset;
                    bw.BaseStream.Position = pDestinationOffset;

                    maxread = pLength > bytes.Length ? bytes.Length : pLength;

                    while ((read = br.Read(bytes, 0, (int)maxread)) > 0)
                    {
                        bw.Write(bytes, 0, read);
                        totalBytes += read;

                        maxread = (pLength - totalBytes) > bytes.Length ? bytes.Length : (pLength - totalBytes);
                    }
                }
            }
        }

        public static void ZeroOutFileChunk(string pPath, long pOffset, int pLength)
        {
            int bytesToWrite = pLength;
            byte[] bytes;

            int maxWrite = bytesToWrite > Constants.FileReadChunkSize ? Constants.FileReadChunkSize : bytesToWrite;

            using (BinaryWriter bw =
                new BinaryWriter(File.Open(pPath, FileMode.Open, FileAccess.Write)))
            {
                bw.BaseStream.Position = pOffset;

                while (bytesToWrite > 0)
                {
                    bytes = new byte[maxWrite];
                    bw.Write(bytes);
                    bytesToWrite -= maxWrite;
                    maxWrite = bytesToWrite > bytes.Length ? bytes.Length : bytesToWrite;
                }
            }
        }

        public static void TrimFileToLength(string path, int totalLength)
        {
            string fullPath = Path.GetFullPath(path);

            if (File.Exists(fullPath))
            {
                string destinationPath = Path.ChangeExtension(fullPath, ".trimmed");
                
                using (FileStream fs = File.OpenRead(path))
                {
                    ParseFile.ExtractChunkToFile(fs, 0, totalLength, destinationPath);
                }

                File.Copy(destinationPath, path, true);
                File.Delete(destinationPath);
            }
        }

        public static string RemoveChunkFromFile(string path, long startingOffset, long length)
        {
            string fullPath = Path.GetFullPath(path);
            
            int bytesRead;
            byte[] bytes = new byte[1024];
            
            string ret = String.Empty;

            if (File.Exists(fullPath))
            {
                string destinationPath = Path.ChangeExtension(fullPath, ".cut");                                

                using (FileStream sourceFs = File.OpenRead(fullPath))
                {
                    // extract initial chunk
                    ParseFile.ExtractChunkToFile(sourceFs, 0, startingOffset, destinationPath);

                    // append remainder
                    using (FileStream outFs = File.Open(destinationPath, FileMode.Append, FileAccess.Write))
                    {
                        sourceFs.Position = startingOffset + length;
                        bytesRead = sourceFs.Read(bytes, 0, bytes.Length);

                        while (bytesRead > 0)
                        {
                            outFs.Write(bytes, 0, bytesRead);
                            bytesRead = sourceFs.Read(bytes, 0, bytes.Length);
                        }
                    }

                    ret = destinationPath;
                }                
            }

            return ret;
        }

        public static string RemoveAllChunksFromFile(FileStream fs, byte[] chunkToRemove)
        {
            int bytesRead;
            
            long currentReadOffset = 0;
            long totalBytesRead = 0;
            int maxReadSize = 0;
            long currentChunkSize;

            byte[] bytes = new byte[Constants.FileReadChunkSize];
            long[] offsets = ParseFile.GetAllOffsets(fs, 0, chunkToRemove, false, -1, -1, true);

            string destinationPath = Path.ChangeExtension(fs.Name, ".cut");

            using (FileStream destinationFs = File.OpenWrite(destinationPath))
            {                
                for (int i = 0; i < offsets.Length; i++)
                {
                    // move position
                    fs.Position = currentReadOffset;

                    // get length of current size to write
                    currentChunkSize = offsets[i] - currentReadOffset;

                    // calculcate max cut size for this loop iteration
                    maxReadSize = (currentChunkSize - totalBytesRead) > (long)bytes.Length ? bytes.Length : (int)(currentChunkSize - totalBytesRead);

                    while ((bytesRead = fs.Read(bytes, 0, maxReadSize)) > 0)
                    {
                        destinationFs.Write(bytes, 0, bytesRead);
                        totalBytesRead += (long)bytesRead;

                        maxReadSize = (currentChunkSize - totalBytesRead) > (long)bytes.Length ? bytes.Length : (int)(currentChunkSize - totalBytesRead);
                    }

                    totalBytesRead = 0;
                    currentReadOffset = offsets[i] + chunkToRemove.Length;
                }
               
                ////////////////////////////
                // write remainder of file
                ////////////////////////////
                // move position
                fs.Position = currentReadOffset;

                // get length of current size to write
                currentChunkSize = fs.Length - currentReadOffset;

                // calculcate max cut size
                maxReadSize = (currentChunkSize - totalBytesRead) > (long)bytes.Length ? bytes.Length : (int)(currentChunkSize - totalBytesRead);

                while ((bytesRead = fs.Read(bytes, 0, maxReadSize)) > 0)
                {
                    destinationFs.Write(bytes, 0, bytesRead);
                    totalBytesRead += (long)bytesRead;

                    maxReadSize = (currentChunkSize - totalBytesRead) > (long)bytes.Length ? bytes.Length : (int)(currentChunkSize - totalBytesRead);
                }
            }

            return destinationPath;
        }

        public static string RemoveAllChunksFromFile(string path, byte[] chunkToRemove)
        {
            string destinationPath;

            using (FileStream fs = File.OpenRead(path))
            {
                destinationPath = RemoveAllChunksFromFile(fs, chunkToRemove);
            }
            
            return destinationPath;
        }

        public static bool ExecuteExternalProgram(
            string pathToExecuatable, 
            string arguments, 
            string workingDirectory, 
            out string standardOut, 
            out string standardError)
        {
            Process externalExecutable;
            bool isSuccess = false;
            
            standardOut = String.Empty;
            standardError = String.Empty;

            using (externalExecutable = new Process())
            {
                externalExecutable.StartInfo = new ProcessStartInfo(pathToExecuatable, arguments);
                externalExecutable.StartInfo.WorkingDirectory = workingDirectory;
                externalExecutable.StartInfo.UseShellExecute = false;
                externalExecutable.StartInfo.CreateNoWindow = true;
                
                externalExecutable.StartInfo.RedirectStandardOutput = true;
                externalExecutable.StartInfo.RedirectStandardError = true;
                isSuccess = externalExecutable.Start();

                standardOut = externalExecutable.StandardOutput.ReadToEnd();
                standardError = externalExecutable.StandardError.ReadToEnd();
                externalExecutable.WaitForExit();
            }
            
            return isSuccess;
        }

        public static void AddHeaderToFile(byte[] headerBytes, string sourceFile, string destinationFile)
        {
            int bytesRead;
            byte[] readBuffer = new byte[Constants.FileReadChunkSize];

            using (FileStream destinationStream = File.Open(destinationFile, FileMode.CreateNew, FileAccess.Write))
            {
                // write header
                destinationStream.Write(headerBytes, 0, headerBytes.Length);

                // write the source file
                using (FileStream sourceStream = File.Open(sourceFile, FileMode.Open, FileAccess.Read))
                {
                    while ((bytesRead = sourceStream.Read(readBuffer, 0, readBuffer.Length)) > 0)
                    {
                        destinationStream.Write(readBuffer, 0, bytesRead);
                    }
                }
            }
        }

        public static void RenameFileUsingInternalName(string path,
            long offset, int length, byte[] terminatorBytes, bool maintainFileExtension)
        {
            string destinationDirectory = Path.GetDirectoryName(path);
            string destinationFile;
            string originalExtension;

            int nameLength;
            byte[] nameByteArray;

            using (FileStream fs = File.OpenRead(path))
            {
                if (terminatorBytes != null)
                {
                    nameLength = ParseFile.GetSegmentLength(fs, (int)offset, terminatorBytes);
                }
                else
                {
                    nameLength = length;
                }

                if (nameLength < 1)
                {
                    throw new ArgumentOutOfRangeException("Name Length", "Name Length is less than 1.");        
                }

                if (maintainFileExtension)
                {
                    originalExtension = Path.GetExtension(path);
                }

                nameByteArray = ParseFile.ParseSimpleOffset(fs, offset, nameLength);
                destinationFile = ByteConversion.GetAsciiText(FileUtil.ReplaceNullByteWithSpace(nameByteArray)).Trim();                
                destinationFile = Path.Combine(destinationDirectory, destinationFile);

                if (maintainFileExtension)
                {
                    originalExtension = Path.GetExtension(path);
                    destinationFile = Path.ChangeExtension(destinationFile, originalExtension);
                }
            }

            // try to copy using the new name
            if (!path.Equals(destinationFile))
            {
                try
                {
                    if (!Directory.Exists(Path.GetDirectoryName(destinationFile)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(destinationFile));
                    }

                    if (File.Exists(destinationFile))
                    {
                        string[] sameNamedFiles = Directory.GetFiles(Path.GetDirectoryName(destinationFile), Path.GetFileNameWithoutExtension(destinationFile) + "*"); 

                        // rename to prevent overwrite
                        destinationFile = Path.Combine(Path.GetDirectoryName(destinationFile), String.Format("{0}_{1}{2}", Path.GetFileNameWithoutExtension(destinationFile), sameNamedFiles.Length.ToString("D4"), Path.GetExtension(destinationFile)));
                    }

                    File.Copy(path, destinationFile);
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }
    }
}
