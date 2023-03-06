﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Foto
{
    public static class Extensions
    {
        public static void GetGrey(this Bitmap bitmap)
        {
            for (int y =0; y<bitmap.Height; y++)
            {
                for (int x =0;x<bitmap.Width;x++)
                {
                    var pixel = bitmap.GetPixel(x, y);
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;
                    bitmap.SetPixel(x, y, Color.FromArgb(pixel.A, avg, avg, avg));
                   
                }
            }

        }
    }
}
