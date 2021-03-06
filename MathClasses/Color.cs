﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Color
    {
        public UInt32 color;
        private byte red = 255;
        private byte green = 255;
        private byte blue = 255;
        private byte alpha = 255;

        public Color()
        {

        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            
        }

        public byte GetRed()
        {
            return (byte)((color & 0xff000000) >> 24);
        }
        public void SetRed(byte red)
        {
            color = color & 0x00ffffff;
            color |= (UInt32)red << 24;
        }

        public byte GetGreen()
        {
            return (byte)((color & 0x00ff0000) >> 24);
        }
        public void SetGreen(byte green)
        {
            color = color & 0xff00ffff;
            color |= (UInt32)green << 16;
        }

        public byte GetBlue()
        {
            return (byte)((color & 0x0000ff00) >> 24);
        }
        public void SetBlue(byte blue)
        {
            color = color & 0xffff00ff;
            color |= (UInt32)blue << 8;
        }

        public byte GetAlpha()
        {
            return (byte)((color & 0x000000ff) >> 24);
        }
        public void SetAlpha(byte alpha)
        {
            color = color & 0xffffff00;
            color |= (UInt32)alpha << 0;
        }
    }
}
