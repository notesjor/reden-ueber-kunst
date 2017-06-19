# Reden über Kunst
Jede documenta will mehr sein als nur eine Ausstellung. Dieses „Mehr“ – politisch-gesellschaftliche Analysen und ästhetisch-konzeptionelle Impulse – wird vor jeder documenta sprachlich vorbereitet. So wird ein Fundament gelegt, das die Ausstellung trägt. Ein Forschungsteam um Andreas Gardt, Professor für germanistische Linguistik, beleuchtet die kommunikativen Muster der d14 anhand von Analysen verschiedenster Texte.

Auf der Homepage sind Analysen zentraler Texte der documenta-Macher visuell aufbereitet. Darin werden ihre zentralen sprachlichen Muster aufgezeigt und durch andere documenta-bezogene Publikationen hindurch verfolgt.

Anmerkung zu #d14tive: Dies war der vorläufige Arbeitstitel d14 + __T__ witter + L __IVE__
Technischer Hintergrund: Die Software wurde in C#/.NET mit Hilfe des CorpusExplorer.SDK entwickelt (http://www.corpusexplorer.de)

## Projektmappenbeschreibung

- __d14tive.ExcelAnalytics__ - Automatische Auswertungen mittels CorpusExplorer. Ausgabe erfolgt als CSV - Die dann mittels Microsoft Excel und Microsoft Power BI visualisiert wird. Visualisierungen werden als PNG-Grafik in die Webseite sowie in d14tive.WindowsClient eingebunden.

- __d14tive.TweetSelector__ - Erlaubt es, ein vorbereitetes Tweet-Korpus (CEC6 - CorpusExplorer) nach individuellen Originaltweets zu durchsuchen (Filtertechnik in d14tive.TweetsToCsv implementiert - siehe OriginalTweetFilter.cs) und besonders relevante Tweets zu markieren (Haken in Spalte "?" setzen). Die erzeugte Ausgaben "tweets.cec6" im Programmverzeichnis, kann in d14tive.WindowsClient angezeigt werden.

- __d14tive.TweetsToCsv__ - Wandelt individuellen Originaltweets aus einem Tweet-Korpus (CEC6 - CorpusExplorer) in eine CSV-Datei um. Diese kann mittels Microsoft Excel ausgedruckt werden.

- __d14tive.WindowsClient__ - Projektion von Tweets und Analysen.
