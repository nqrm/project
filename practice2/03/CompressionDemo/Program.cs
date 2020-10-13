﻿using System;
using System.IO;
using System.IO.Compression;

namespace CompressionDemo
{
    class Program
    {
        /*static void CompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
           while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte); theByte = sourceFile.ReadByte();
            }
            compStream.Close();
        }*/

        static void UncompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }
            compStream.Close();
        }
            static void Main(string[] args)
        {
            //CompressFile(@"D:\newfile.txt", @"D:\newfile.txt.gz");
            UncompressFile(@"D:\newfile.txt.gz", @"D:\newfile1.txt");
        }

    }
}
