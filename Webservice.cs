// ===================================================================================
// Einsendeaufgabe 4.4 (Webservices)
// Modul: Betriebliche Informationssysteme
// Autor: Doniman Francisco Peña Parra
// Erstellungsdatum: 25. Mai 2025
// Sprache: C# (.NET 8.0) – Visual Studio Code
// Beschreibung:
//      Diese Klasse simuliert einen einfachen Webservice, der zwei Methoden bereitstellt:
//      - Angebotserstellung aus XML-Anfragen
//      - Auftragsbestätigung basierend auf Angebotsdaten
// ===================================================================================

using System;          // Basisfunktionen wie DateTime
using System.Xml;      // Für XML-Dokument-Verarbeitung

public class Webservice
{
    /// <summary>
    /// Verarbeitet eine XML-Anfrage mit Artikelnummer und Menge
    /// und erstellt ein Angebots-XML mit Gesamtpreis und Lieferdatum.
    /// </summary>
    /// <param name="xmlEingabe">XML-String mit Anfrage</param>
    /// <returns>Antwort-XML mit Preis und Lieferdatum</returns>
    public string ErstelleAngebot(string xmlEingabe)
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlEingabe); // XML wird geladen

        // Extrahiere Werte aus XML
        string artikelnummer = doc.SelectSingleNode("//artikelnummer")?.InnerText;
        int menge = int.Parse(doc.SelectSingleNode("//menge")?.InnerText);

        // Preisfindung je nach Artikelnummer
        float preisProStueck = artikelnummer switch
        {
            "A123" => 25.0f,
            "B456" => 50.0f,
            "C789" => 75.0f,
            _ => 0.0f
        };

        float gesamtpreis = preisProStueck * menge; // Gesamtsumme berechnen

        // XML-Antwort zurückgeben
        return $@"<angebot>
<artikelnummer>{artikelnummer}</artikelnummer>
<gesamtpreis>{gesamtpreis}</gesamtpreis>
<lieferdatum>{DateTime.Today.AddDays(7):yyyy-MM-dd}</lieferdatum>
</angebot>";
    }

    /// <summary>
    /// Nimmt ein Angebots-XML entgegen und bestätigt den Auftrag
    /// mit aktuellem Zeitstempel und Lieferdatum.
    /// </summary>
    /// <param name="xmlAngebot">XML mit Angebot</param>
    /// <returns>Auftragsbestätigungs-XML</returns>
    public string AuftragEntgegennehmen(string xmlAngebot)
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlAngebot); // XML wird geladen

        // Extrahiere Informationen aus Angebot
        string artikelnummer = doc.SelectSingleNode("//artikelnummer")?.InnerText;
        string lieferdatum = doc.SelectSingleNode("//lieferdatum")?.InnerText;

        // XML-Bestätigung erzeugen
        return $@"<auftragsbestaetigung>
<status>erhalten</status>
<artikelnummer>{artikelnummer}</artikelnummer>
<bestaetigtAm>{DateTime.Now:yyyy-MM-ddTHH:mm:ss}</bestaetigtAm>
<lieferdatum>{lieferdatum}</lieferdatum>
</auftragsbestaetigung>";
    }
}
