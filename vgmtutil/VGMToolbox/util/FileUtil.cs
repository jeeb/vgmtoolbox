﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VGMToolbox.util
{
    public class FileUtil
    {
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
                    throw new EndOfStreamException
                        (String.Format("End of stream reached with {0} bytes left to read", remaining));
                remaining -= read;
                offset += read;
            }
        }
        
        public static byte[] ReplaceNullByteWithSpace(byte[] pBytes)
        {
            for (int i = 0; i < pBytes.Length; i++)
            {
                if (pBytes[i] == 0x00)
                {
                    pBytes[i] = 0x20;
                }
            }

            return pBytes;
        }

        public static int GetFileCount(string[] pPaths)
        {
            int totalFileCount = 0;
            
            foreach (string path in pPaths)
            {
                if (File.Exists(path))
                {
                    totalFileCount++;
                }
                else if (Directory.Exists(path))
                {
                    totalFileCount += Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Length;
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

        public static void UpdateTextField(string pFilePath, string pFieldValue, int pOffset,
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

        public static void ReplaceFileChunk(string pSourceFilePath, long pSourceOffset,
            long pLength, string pDestinationFilePath, long pDestinationOffset)
        {
            int read = 0;
            long maxread;
            int totalBytes = 0;
            byte[] bytes = new byte[Constants.FILE_READ_CHUNK_SIZE];

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

            int maxWrite = bytesToWrite > Constants.FILE_READ_CHUNK_SIZE ? Constants.FILE_READ_CHUNK_SIZE : bytesToWrite;

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
    }
}
