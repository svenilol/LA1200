# Projekt-Dokumentation

Gruppe Beaver: Bächli Sven, Bytyqi Artur, Hitz Julian, Oesch Jonah, Gilardoni Raul

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    25.10.2022   | 0.1   | Gruppenleiter entschieden und Projektdokumentation bearbeitet |
|   01.11.2022    | 0.2   |    Erstes Programmieren und weiter an der Projektdokumentation arbeiten.          |
|  08.11.2022     | 0.3   |   Projektdokumentation fertigstellen, Code fertigstellen und Testen      |
| 15.11.2022 | 1.0.0 | Kontrollieren, Testprotokoll fertigstellen und Projekt Abschliessen |

## 1 Informieren

### 1.1 Ihr Projekt

Unseres Vokabular-Abfrage-Programm soll auf verschiedene Fremdsprachen das Vokabular abfragen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss  |   Funktional   | Als ein User möchte ich, dass das Programm mich auf Fremdsprachen abfragt, damit ich auf Grund den Anforderungen richtig unterrichtet werde.  |
| 2  |  Muss               |  Funktional    |       Als ein User möchte ich, dass das Programm mich auf Zwei Sprachen abfragt                            |
| 3  | Muss  |Funktional|Als ein User möchte ich, dass das Programm mir meine Punktzahl am Schluss zeigt.|
| 4  |Muss |Funktional|Als ein User möchte ich, dass das Programm nicht die gleichen Wörter wieder benutzt, nachdem man sie richtig gehabt hat|
| 5  |Kann|Funktional|Als ein User möchte ich, dass das Programm mehrere Schwierigkeitsgraden hat|
| 6  |Kann|Qualität|Als ein User möchte ich, dass das Programm in einer Windows Forms-Art programmiert wird|
| 7  |  Kann               |  Funktional    |Als ein User möchte ich einen "Speedrun-Mode" haben, damit man nicht so lange Zeit hat, um etwas zu erraten|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |       Wörter die abgefragt werden       |    Richtiges Wort     |      Wort korrekt -> nächstes Wort             |
| 1.2  |       Wörter die abgefragt werden       |    Falsches Wort     |      Wort falsch -> nächstes Wort; Wort wird nicht mehr abgefragt und man bekommt Minuspunkte            |
| 1.3  |       Wörter die abgefragt werden       |    Ungültige Eingabe     |      "Keine Nummern, nur Wörter!"             |
| 2.1  |     Auswahl Sprache        |     Deutsch->Englisch    |     Deutsch zu Englisch wird Abgefragt              |
| 2.2 | Auswahl Sprache | Englisch -> Deutsch | Englisch zu Deutsch wird Abgefragt |
| 2.3 | Auswahl Sprache | Ungültige Eingabe | "Wähle aus welche Sprache du willst." |
| 3.1  |      Alle Wörter fertig abgefragt        |   Punktzahl      |      "Sie haben 30 von 45 richtig gelöst."             |
| 3.2  |      Alle Wörter fertig abgefragt        |   volle Punktzahl      |      "Sie haben 45 von 45 richtig gelöst. Wow!"            |
| 4.1  |       Wort fertig eingegeben       |     Nächstes Wort    |       Nicht nochmal das Gleiche, sondern ein anderes Random von der Liste            |
| 5.1  |    Schwierigkeitsgrad eingeben          |   Leicht      |    "Sie haben die leichten Wörter ausgewählt"               |
| 5.2  |    Schwierigkeitsgrad eingeben          |   Schwer      |    "Sie haben die schweren Wörter ausgewählt"               |
| 5.3  |    Schwierigkeitsgrad eingeben          |   Ungültige Eingabe      |    "Wählen Sie eine Schwierigkeit aus!"              |
| 7.1  |   Schwierigkeitsgrad eingeben          |   Speedrun      |     Zeit die gemessen wird; Beste Zeit wird am Schluss angezeigt             |



### 1.4 Diagramme

![Hauptprogramm](https://user-images.githubusercontent.com/110893098/201853639-c8947ed1-d646-40d7-92c7-f84a7357b33b.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|   1.a    |     08.11.22    |   Sven   |   Die Fremdsprache einsstellen können            |    30 min     |
|   1.d    |   08.11.22      |     Raul |    Die Wörter abfragen |   60 min |
|   1.e    |   08.11.22      |     Raul |    Die Wörter eingeben können |   45 min |
|   2.a    |     08.11.22    |   Sven   |   Entscheiden welche Übersetzung man möchte          |    30 min     |
|   2.b    |   08.11.22      |     Julian   | Entscheiden De -> En              |    15 min      |
|   2.c    |   08.11.22      |     Julian   | Entscheiden En -> De              |    15 min      |
|   3.a    |  08.11.22       |      Sven  | Punktzahl anzeigen lassen   |     30 min    |
|   3.b    |   08.11.22      |     Sven   | Counter hinzufügen             |    30 min      |
|   3.c    |  08.11.22       |     Jonah  | Punkzahl wird am Schluss angezeigt         |     30 min    |
|   4.a    |   08.11.22      |       Raul, Julian |  Random Wörter abfragen|   90 min       |
|   4.b    |   08.11.22      |       Artur |  Richtige Eingabe erkennen |   40 min       |
|   4.b    |   08.11.22      |       Artur |  Bei richtige Eingabe -> Wort nicht erneut abfragen |   40 min       |
|   4.c    |   08.11.22      |       Jonah |  Falsche Eingabe erkennen |   40 min       |
|   4.d    |   08.11.22      |       Jonah |  Bei falsche Eingabe -> Wort erneut abfragen |   40 min       |
|5.a |   08.11.22|  Artur|Schwierigkeitsgrad einstellen |    60  min    |
|5.b |   08.11.22|  Jonah| Liste von Wörtern machen|    30  min    |
|5.c |   08.11.22|  Artur| Verschiedene Wörter für ausgewählte Schwierigkeit benutzen|    30  min    |
|   6.a    |   08.11.22      |   Artur, Jonah     |    In Windows Forms-art Programmieren           |     120 min     |
|   7.a    |   08.11.22      |    Julian    |    Speedrun-mode machen         |    30  min    |
|   7.b    |   08.11.22      |    Julian    |    Speedrun-mode als Stoppuhr machen         |    30  min    |
|   7.c    |   08.11.22      |    Artur   |    Speedrun-mode als Schwierigkeit hinzufügen         |    15  min    |
|   7.d   |   08.11.22      |    Sven |    Speedrun-mode zeigt bestes Ergebnis am Schluss|    20  min    |
|   7.e    | 08.11.22|Sven, Raul |Speedrun als schwerste Schwierigkeit machen |20 min   |
| Total: | | | |900 min   |





## 3 Entscheiden

Wir mussten uns entscheiden, welche Funktionen wir einbauen wollten und schauen, ob man sie in der Theorie umsetzen kann, sodass es keine Komplikationen geben würde. Bei der User Story haben wir die Nummer 6 Ausgelassen und andere funktionale User Storys ausgelassen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   1.11.22    |  Sven    |       30 min         |      60 min        |
| 1.B  |   1.11.22     |     Raul      |  90 min             |      180 min             |
| 2.A  |  1.11.22      |         Julian  |   30 min            |         45 min          |
| 3.A  |   1.11.22     |     Sven      |    45 min           |            30 min       |
| 3.B  |   1.11.22     |     Jonah     |    30 min           |            30 min       |
| 4.A  |  8.11.22      |         Raul, Julian  |    90 min           |            90 min       |
| 5.A  |  8.11.22     | Artur          |     90 min          |           120 min        |
| 6.A  |   8.11.22    |      Artur, Jonah     |     120 min          |             -     |
| 7.A  |  8.11.22     |    Julian       |      30 min         |               -    |
| 7.B  | 8.11.22      |          Sven, Raul |       45 min        |                -   |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  15.11.22     |  Funktioniert, nächstes wort wird abgefragt.        |   Jonah     |
| 1.2  |  15.11.22     |  Funktioniert, der minus punkt funktioniert nicht      | Jonah       |
| 1.3  |  15.11.22     |   Funktioniert nicht Ausgabe ist Falsches Wort       |   Jonah     |
| 2.1  |  15.11.22     |  Funktioniert        |   Jonah     |
| 2.2  |  15.11.22     |   Funktioniert       |    Jonah    |
| 2.3  |  15.11.22     |   Funktioniert       |    Jonah    |
| 3.1  |  15.11.22     |   Funktioniert nicht       |  Jonah      |
| 3.2  |  15.11.22     |   Funktioniert nicht       |   Jonah     |
| 4.1  |  15.11.22     |   Funktioniert       |  Jonah      |
| 5.1  |  15.11.22     |   Funktioniert       |   Jonah     |
| 5.2  |  15.11.22     |   Funktioniert       |  Jonah      |
| 5.3  |  15.11.22     |   Funktioniert nicht       |   Jonah     |
| 7.1  |  15.11.22     |   Funktioniert nicht       |   Jonah     |


## Fazit:
Generell ist das Programm nicht beendet, da wir ein Paar technische Probleme hatten.

## 6 Auswerten

https://github.com/svenilol/LA1200/blob/main/Lern-Bericht.md
