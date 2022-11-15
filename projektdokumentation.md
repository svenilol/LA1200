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
|   1.b    |   08.11.22      |     Raul |    Die Wörter abfragen, eingeben können   |   90 min |
|   2.a    |   08.11.22      |     Julian   | Entscheiden De -> En oder En -> De              |    30 min      |
|   3.a    |  08.11.22       |      Sven  | Punktzahl anzeigen lassen und Counter hinzufügen         |     45 min    |
|   3.b    |  08.11.22       |     Jonah  | Punkzahl wird am Schluss angezeigt         |     30 min    |
|   4.a    |   08.11.22      |       Raul, Julian |  Random Wörter abfragen wenn man sie richtig hatte nicht erneut abfragen             |   90 min       |
|   5.a    |   08.11.22      |  Artur      |  Schwierigkeitsgrad einstellen und verschiedene Wörter für ausgewählte Schwierigkeit benutzen             |    90  min    |
|   6.a    |   08.11.22      |   Artur, Jonah     |    In Windows Forms-art Programmieren           |     120 min     |
|   7.a    |   08.11.22      |    Julian    |    Speedrun-mode zu den Schwirigkeitsgraden hinzufügen           |    30  min    |
|   7.b    | 08.11.22|Sven, Raul |Speedrun ist schwerste Schwierigkeit und wird auf Zeit gestoppt schnellstes Ergebnis wird ahngezeigt.|45 min   |


Total:| | | |570 min|


## 3 Entscheiden

Wir mussten uns entscheiden welch Funktionen wir einbauen und schauen ob man sie in der Theorie umsetzten kann sodass es keine Komplikationen geben wird. Bei der User Story haben wir die Nummer 6 Ausgelassen und andere

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
| 1.1  |  15.11.22     |  Funktionier, nächstes wort wird abgefragt.        |   Jonah     |
| 1.2  |  15.11.22     |  Funktioniert, der minus punkt funktioniert nicht      | Jonah       |
| 1.3  |  15.11.22     |   Funktioniert nicht Ausgabe ist Falsches Wort       |   Jonah     |
| 2.1  |  15.11.22     |  Funktioniert        |   Jonah     |
| 2.2  |  15.11.22     |   Funktioniert       |    Jonah    |
| 2.3  |  15.11.22     |   Funktioniert       |    Jonah    |
| 3.1  |  15.11.22     |   Funktioniert nicht       |  Jonah      |
| 3.2  |  15.11.22     |   Funktioniert nciht       |   Jonah     |
| 4.1  |  15.11.22     |   Funktioniert       |  Jonah      |
| 5.1  |  15.11.22     |   Funktioniert       |   Jonah     |
| 5.2  |  15.11.22     |   Funktioniert       |  Jonah      |
| 5.3  |  15.11.22     |   Funktioniert nicht       |   Jonah     |
| 7.1  |  15.11.22     |   Funktioniert nich       |   Jonah     |


## Fazit:
Wie haben die kann Testfälle meist nicht gemacht weil wir Zeitdruck hatten.

## 6 Auswerten

https://github.com/svenilol/LA1200/edit/main/Lern-Bericht
