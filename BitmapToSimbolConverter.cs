using System;
using System.Drawing;

namespace Foto
{
    class BitmapToSymbolConverter
    {
        // ASCII-Tabelle von dunklen ('.') bis hellen ('@') Zeichen
        private readonly char[] _asciiTable = { '.', ',', ':', '+', '*', '?', '%', 'S', '#', '@' };

        private readonly Bitmap _bitmap;

        public BitmapToSymbolConverter(Bitmap bitmap)
        {
            _bitmap = bitmap;
        }

        // Methode zur Konvertierung der Bitmap in ein 2D-Array aus ASCII-Zeichen
        public char[][] Convert()
        {
            char[][] result = new char[_bitmap.Height][];

            for (int y = 0; y < _bitmap.Height; y++)
            {
                result[y] = new char[_bitmap.Width];

                for (int x = 0; x < _bitmap.Width; x++)
                {
                    // Grauwert des Pixels auf ASCII-Index abbilden
                    int mapIndex = (int)Map(_bitmap.GetPixel(x, y).R, 0, 255, 0, _asciiTable.Length - 1);
                    result[y][x] = _asciiTable[mapIndex];
                }
            }
            return result;
        }

        // In meinem Code wird die Methode Map verwendet,
        // um den Helligkeitswert eines Pixels (im Bereich von 0 bis 255)
        // in einen Index des Zeichenarrays _asciiTable umzuwandeln, das verschiedene Helligkeitsstufen mit ASCII-Zeichen darstellt.
        private float Map(float valueToMap, float start1, float stop1, float start2, float stop2)
        {
            return ((valueToMap - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }
    }
}
