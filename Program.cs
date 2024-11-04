using System;
using System.Windows.Forms;
using System.Drawing;


namespace Foto
{
    class Program
    {
        // Breitenfaktor zur Anpassung der Bildverhältnisse
        private const double WIDTH_OFFSET = 1.5;
        // Maximale Breite des Bildes in Pixeln
        private const int MAX_WIDTH = 350;

        [STAThread]
        static void Main(string[] args)
        {
            // Dialog zum Öffnen einer Bilddatei
            var openFile = new OpenFileDialog
            {
                Filter = "Images| *.bmp; *.jpg; *.png; *.JEPEG; *.JPG; "
            };

            Console.WriteLine("DRÜCKEN SIE ENTER ZUM STARTEN");

            while (true)
            {
                Console.ReadLine(); // Warte auf Eingabe

                // Überprüfen, ob die Datei erfolgreich geöffnet wurde
                if (openFile.ShowDialog() != DialogResult.OK)
                    continue;

                Console.Clear(); // Konsolenbildschirm löschen

                // Bild laden und in Graustufen konvertieren
                var bitmap = new Bitmap(openFile.FileName);
                bitmap = ResizeBitmap(bitmap);
                bitmap.GetGrey();

                // Konvertieren des Bildes in ASCII-Zeichen
                var converter = new BitmapToSymbolConverter(bitmap);
                var rows = converter.Convert();

                // ASCII-Bildzeilen in der Konsole ausgeben
                foreach (var row in rows)
                    Console.WriteLine(row);

                // Cursor auf den Anfang der Konsole zurücksetzen
                Console.SetCursorPosition(0, 0);
            }
        }

        // Methode zur Anpassung der Bildgröße
        private static Bitmap ResizeBitmap(Bitmap bitmap)
        {
            var maxWidth = MAX_WIDTH;
            var newHeight = bitmap.Height / WIDTH_OFFSET * maxWidth / bitmap.Width; // Neue Höhe basierend auf Verhältnis berechnen

            // Bildgröße anpassen, wenn es größer als die maximale Breite oder Höhe ist
            if (bitmap.Width > maxWidth || bitmap.Height > newHeight)
                bitmap = new Bitmap(bitmap, new Size(maxWidth, (int)newHeight));

            return bitmap;
        }
    }

}
