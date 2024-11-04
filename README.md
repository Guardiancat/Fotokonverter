ASCII-Bildkonverter
Ein Programm, das ein Bild in Schwarz-Weiß-ASCII-Kunst umwandelt. Dabei wird jeder Pixel des Bildes durch ein Zeichen ersetzt, wobei dunkle Pixel durch . (der dunkelste) und helle Pixel durch % oder @ (die hellsten) dargestellt werden.

Beschreibung
Dieses Programm nimmt ein Bild, ändert seine Größe (falls erforderlich), konvertiert es in Graustufen und ersetzt dann jeden Pixel durch ein ASCII-Zeichen, das seinem Helligkeitsgrad entspricht. Die verwendete Zeichentabelle reicht von dunklen bis hin zu hellen Zeichen: . , : + * ? % S # @.

Funktionen
Bildgrößenänderung: Das Programm verkleinert das Bild auf eine feste Breite, sodass es in die Konsole passt und das Seitenverhältnis beibehalten wird.
Umwandlung in Graustufen: Das Programm konvertiert das Bild in Graustufen, indem es den durchschnittlichen RGB-Wert für jeden Pixel berechnet.
Umwandlung in ASCII: Die Helligkeit jedes Pixels wird mit dem entsprechenden Zeichen in der ASCII-Tabelle abgebildet, um eine visuelle Darstellung zu erstellen.
Anwendung
Programmstart: Starten Sie die Anwendung in der Konsole, und Sie sehen die Nachricht „НАЖМИТЕ ЕNTER ДЛЯ СТАРТА“.
Datei öffnen: Nach dem Drücken der Eingabetaste wird ein Dialogfenster geöffnet, in dem Sie ein Bild auswählen können.
Ausgabe in der Konsole: Das konvertierte Bild wird als ASCII-Zeichen in der Konsole angezeigt.
Code-Struktur
Program: Die Hauptklasse, die das Programm startet, das Bild lädt und die Ausgabe steuert.
Extensions: Eine Erweiterung für die Klasse Bitmap, die die Methode GetGrey hinzufügt, um das Bild in Graustufen umzuwandeln.
BitmapToSymbolConverter: Eine Klasse zur Konvertierung des Bildes in ASCII-Kunst. Enthält die Methode Convert, die jeden Pixel je nach Helligkeit in ein ASCII-Zeichen umwandelt.
Anwendungsbeispiel
Ein Beispielbild, das in ASCII umgewandelt wurde:
@@@@@@@@@@%%%***+:::,,,,,
@@%%%%%%*?+++::::,,,,....
%%%%??++:,,,,.......
Voraussetzungen
.NET 8.0
Visualisierung in der Konsole (russische Version von Visual Studio)
Installation
Klonen Sie das Repository:

git clone https://github.com/benutzername/ascii-image-converter.git
Öffnen Sie das Projekt in Visual Studio und starten Sie es.

Hinweis
Dieses Programm wurde als Hobbyprojekt erstellt.
