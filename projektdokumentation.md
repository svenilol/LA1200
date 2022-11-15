# Projekt-Dokumentation

Gruppe Beaver: Bächli Sven, Bytyqi Artur, Hitz Julian, Oesch Jonah, Gilardoni Raul

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    25.10.2022   | 0.1   | Gruppenleiter entschieden und Projektdokumentation bearbeitet |
|   01.11.2022    | 0.2   |    Erstes Programmieren und weiter an der Projektdokumentation arbeiten.          |
|  08.11.2022     | 0.3   |   Projektdokumentation fertigstellen, Code fertigstellen und Testen      |
| 15.11.2022 | 1.0.0 | Kontrollieren, Testprotokol fertigstellen und Projekt Abschliessen |

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
| 1.1  |       Wörter die abgefragt werden       |    Richtiges Wort     |      Wort korrekt nächstes Wort             |
| 2.1  |     Wählen welche sprache         |     De->En    |     De zu En wird Abgefragt              |
| 2.2 | Wähle welche Sprache | En-> De | En zu De wird Abgefragt |
| 3.1  |      Alle wörter fertig abgefragt        |   Punktzahl      |      Sie haben 30von 45 richtig gelöst.             |
| 4.1  |       Wort fertig eingegeben       |     Nächstes Wort    |       Nicht nochmal das gleiche sondern ein anderes randum von der liste            |
| 5.1  |    Schwierikeits grad eingeben          |   Leicht      |    Sie haben die Leichten Wörter ausgewählt               |
|  6.1 |                                        |                |                                                       |
| 7.1  |   Sie wählen schwirigkeit speedrun           |   erstes Wort      |     Zeit die gemessen wird beste zeit wird am schluss angezeigt             |


### 1.4 Diagramme

![Hauptprogramm](https://user-images.githubusercontent.com/110893098/201853639-c8947ed1-d646-40d7-92c7-f84a7357b33b.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|   1.a    |     08.11.22    |    ?    |   Die Fremdsprache einsstellen können            |    30 min     |
|   1.b    |   08.11.22      |        ?   |    Die Wörter Abfragen, eingebne können   |   90 min |
|   2.a    |   08.11.22      |     ?   | Entscheiden De -> En oder En -> De              |    30 min      |
|   3.a    |  08.11.22       |      ?  | Punktzahl anzeigen lassen Counter hinzufügen         |     45 min    |
|   4.a    |   08.11.22      |       ? |  Random Wörter abfragen wenn mann sie richtig ahtte nicht erneut abfragen             |   90 min       |
|   5.a    |   08.11.22      |  ?      |  Schwirigkeitsgraad einstellar udn verschieden wörter für alle schwirigkeiten             |    90  min    |
|   6.a    |   08.11.22      |   ?     |    In Windows Forms-art Programmieren           |     120 min     |
|   7.a    |   08.11.22      |    ?    |    Speedrunn mode zu den Schwirigkeitsgraden hinzufügen           |    30  min    |
|   7.b    |   08.11.22      |     ?   |   Speedrunn ist schwerste Schwirigkeit und wird auf Zeit gestoppt schnellstes ergebniss wird ahngezeigt.            |   45 min       |
Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Wir mussten uns entscheiden welch Funktionen wir einbauen und schauen ob man sie in der Theorie umsetzten kann sodass es keine Komplikationen geben wird.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   1.11.22    |           |       30 min         |                   |
| 1.B  |   1.11.22     |           |  90 min             |                   |
| 2.A  |  1.11.22      |           |   30 min            |                   |
| 3.A  |   1.11.22     |           |    45 min           |                   |
| 4.A  |  8.11.22      |           |    90 min           |                   |
| 5.A  |  8.11.22     |           |     90 min          |                   |
| 6.A  |   8.11.22    |           |     120 min          |                   |
| 7.A  |  8.11.22     |           |      30 min         |                   |
| 7.B  | 8.11.22      |           |       45 min        |                   |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  15.11.22     |          |        |
| 2.1  |  15.11.22     |          |        |
| 3.1  |  15.11.22     |          |        |
| 1.1  |  15.11.22     |          |        |
| 1.1  |  15.11.22     |          |        |
| 1.1  |  15.11.22     |          |        |
| 1.1  |  15.11.22     |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## Fazit:


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
