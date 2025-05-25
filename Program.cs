// ===================================================================================
// Einsendeaufgabe 4.4 (Webservices)
// Modul: Betriebliche Informationssysteme
// Autor: Doniman Francisco Peña Parra
// Erstellungsdatum: 25. Mai 2025
// Sprache: C# (.NET 8.0) – Visual Studio Code
// Beschreibung:
//      Dieses Programm simuliert einen einfachen SOAP-ähnlichen Webservice.
//      Es verarbeitet eine XML-Anfrage, erstellt daraus ein Angebot und 
//      gibt anschließend eine Auftragsbestätigung zurück.
// ===================================================================================

using System; // Importiert die Systembibliothek für Konsolen- und Basisfunktionen

class Program
{
    static void Main()
    {
        // Erstellt eine neue Instanz der Webservice-Klasse
        var service = new Webservice();

        // Beispielhafte XML-Anfrage mit Artikelnummer und Menge
        string anfrageXml = @"<anfrage><artikelnummer>A123</artikelnummer><menge>4</menge></anfrage>";

        // Übergibt die Anfrage an den Webservice und empfängt ein Angebots-XML
        string angebot = service.ErstelleAngebot(anfrageXml);

        // Gibt das erzeugte Angebot auf der Konsole aus
        Console.WriteLine("Antwort Angebot:\n" + angebot);

        // Übergibt das Angebot erneut an den Webservice zur Auftragsbestätigung
        string bestaetigung = service.AuftragEntgegennehmen(angebot);

        // Gibt die erhaltene Auftragsbestätigung auf der Konsole aus
        Console.WriteLine("Antwort Auftrag:\n" + bestaetigung);
    }
}
