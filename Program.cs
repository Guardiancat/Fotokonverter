using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Foto
{
    class Program
    {
        private const double WIDTH_OFFSET = 1.5;
        private const int MAX_WIDTH = 350;

        [STAThread]
        static void Main(string[] args)
        {

            var openFail = new OpenFileDialog
            {
                Filter = "Images| *.bmp; *.jpg; *.png; *.JEPEG; *.JPG; "
            };
            
            Console.WriteLine("НАЖМИТЕ ЕNTER ДЛЯ СТАРТА");


            while(true)
            {
                Console.ReadLine();//пауза перед действием

                if (openFail.ShowDialog() != DialogResult.OK)//если картинка открылась 
                    continue;

                Console.Clear();//очищаем консоль


                var bitmap = new Bitmap(openFail.FileName);
                bitmap = ResizeBitmap(bitmap);

                bitmap.GetGrey();

                var converter = new BitmapToSimvolConverter(bitmap);
                var rows = converter.Convert();

                foreach(var raw in rows)
                    Console.WriteLine(raw);

                Console.SetCursorPosition(0, 0);
            }
        }
        private static Bitmap ResizeBitmap(Bitmap bitmap)
        {
            var maxWidth = MAX_WIDTH;
            var newHeigth = bitmap.Height / WIDTH_OFFSET * maxWidth / bitmap.Width;//если картинка больше по высоте или ширине
            if (bitmap.Width > maxWidth || bitmap.Height > newHeigth)
                bitmap = new Bitmap(bitmap, new Size(maxWidth, (int)maxWidth));//то мы её ресайзим
            return bitmap;

        }
    }

}
