﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VGMToolbox.format
{
    public class Cdxa
    {
        public static readonly byte[] XA_SIG =
            new byte[] { 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00 };

        public static readonly byte[] XA_RIFF_HEADER =
            new byte[] { 
                0x52, 0x49, 0x46, 0x46, 0x84, 0x6E, 0x7D, 0x00, 0x43, 0x44, 0x58, 0x41, 0x66, 0x6D, 0x74, 0x20, 
                0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x55, 0x58, 0x41, 0x01, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x64, 0x61, 0x74, 0x61, 0x60, 0x6E, 0x7D, 0x00 };

        public const long FILESIZE_OFFSET = 0x04;
        public const long DATA_OFFSET = 0x2C;

        public const int XA_BLOCK_SIZE = 2352;
        public const int XA_TRACK_OFFSET = 0x10;
        public const int XA_TRACK_SIZE = 0x04;
        public const string XA_FILE_EXTENSION = ".xa";        
    }
}
