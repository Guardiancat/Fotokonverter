﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foto
{
    class BitmapToSimvolConverter
    {
        private readonly char[] _asciiTabel = { '.', ',', ':', '+', '*', '?', '%', 'S', '#', '@' };

        private readonly Bitmap _bitmap;
        public BitmapToSimvolConverter(Bitmap bitmap)
        {

            _bitmap = bitmap;
        }
           
        public char[][] Convert()
        {
            char[][] rezault = new char[_bitmap.Height][];
            
         
            for (int y = 0; y < _bitmap.Height; y++) 
            {
                rezault[y] = new char[_bitmap.Width];
                for (int x=0; x <_bitmap.Width;x++)
                {
                    int mapIndex = (int)Map(_bitmap.GetPixel(x, y).R, 0, 255, 0, _asciiTabel.Length -1);
                    rezault[y][x] = _asciiTabel[mapIndex]; 
                }
            }
            return rezault;
        }
        private float Map (float velueToMap, float start1,float stop1, float start2,float stop2)
        {
            return ((velueToMap - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }
    }
}