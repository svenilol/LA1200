# Projekt-Dokumentation

Gruppe Beaver: Bächli Sven, Bytyqi Artur, Hitz Julian, Oesch Jonah, Gilardoni Raul

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    25.10.2022   | 0.1   | Gruppenleiter entschieden und Projektdokumentation bearbeitet |
|   01.11.2022    | 0.2     |    Erstes Programmieren und weiter an der Projektdokumentation arbeiten.          |
|  08.11.2022     | 0.3   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Unseres Vokabular-Abfrage-Programm soll auf verschiedene Fremdsprachen das Vokabular abfragen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss         |   Funktional   | Als ein User möchte ich, dass das Programm mich auf Fremdsprachen abfragt, damit ich auf Grund den Anforderungen richtig unterrichtet werde.  |
| 2  |  Muss               |  Funktional    |       Als ein User möchte ich, dass das Programm mich auf Zwei Sprachen abfragt                            |
| 3  | Muss  |Funktional|Als ein User möchte ich, dass das Programm mir meine Punktzahl am Schluss zeigt|
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
| 6.1  |   Ist in der console Programmiert           |   Kann es auch in Windows Forms art Programiert werden      |  Ja wenn man die zeit und dass Wissen dazu hat   |
| 7.1  |   Sie wählen schwirigkeit speedrun           |   erstes Wort      |     Zeit die gemessen wird beste zeit wird am schluss angezeigt             |
|      |              |         |                   |


### 1.4 Diagramme

<img width="503" alt="image" src="https://user-images.githubusercontent.com/110893098/197728488-b76b5ffb-d778-48da-933d-2cf3b2cbad55.png">
<img width="529" alt="image" src="https://user-images.githubusercontent.com/110893098/197728635-d099ca26-a1b9-445c-9c1f-05d270202a05.png">
<img width="571" alt="image" src="https://user-images.githubusercontent.com/110893098/197728814-e05da1d4-91a2-4d72-a429-5b4f8bae1ac8.png">
<img width="526" alt="image" src="https://user-images.githubusercontent.com/110893098/197728899-2f120593-b29c-46fb-9474-dd47c8cbc363.png">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.D  |1.11.2022| Ganze Gruppe|Als ein User möchte ich, dass das Programm mich auf Fremdsprachen abfragt, damit ich auf Grund den Anforderungen richtig unterrichtet werde.|4 * 45|
| 1.E  |  8.11.2022     |   Oesch Jonah        |    Testfälle          |     60 min          |
| 1.F | bis Projekt ende | Alle der Gruppe | erstes Programmieren | 4*45 |
Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Wir musten uns entscheiden welch Funktionen wir eibauen und schauen ob man sie in der theorie umsetzten kann sodass es keine komplikationen gebne wird.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
