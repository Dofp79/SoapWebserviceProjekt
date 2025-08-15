## 🔷 SOAP Webservice Projekt – Angebotserstellung und Auftragsverarbeitung in C# (.NET) 🔷

Willkommen zum **SOAP Webservice Projekt im Rahmen der Einsendeaufgabe 4.4** des Moduls *Betriebliche Informationssysteme*!  
Dieses Repository enthält ein vollständiges Beispiel für einen SOAP-basierten Webservice, implementiert in **C# mit .NET 8.0**.

Ziel dieses Projekts ist es, dem Auszubildenden/Studierenden ein fundiertes Verständnis über die Erstellung und Nutzung von SOAP-Webdiensten zu vermitteln – inklusive Angebotserstellung, Auftragsannahme und typischer Webmethoden.

---

## Thema & Projektziel

**Thema:**  
„SOAP Webservice zur Angebotserstellung und Auftragsverarbeitung mit C# und .NET“

**Zielsetzung:**  
Dieses Thema wurde gewählt, um praxisnahe Kompetenzen im Umgang mit **SOAP (Simple Object Access Protocol)** aufzubauen.  
Dies ist besonders wichtig im Kontext betrieblicher Informationssysteme, wo robuste Webservice-Kommunikation erforderlich ist.

Durch das Projekt lernt der Teilnehmende:

- Wie man mit **Visual Studio / VS Code** ein SOAP Webservice-Projekt erstellt
- Wie man **Methoden für Angebotslogik** implementiert
- Wie man XML-kompatible Datenstrukturen verwendet
- Wie man **SOAP-Clients** zur Nutzung dieser Schnittstelle erstellt

---

## Lernziele

### Richtlernziel
Der Teilnehmer kann einen SOAP Webservice in C# entwickeln, strukturieren und mit typischen Methoden (z. B. Angebot berechnen) ausstatten.

### Groblernziele
- Verständnis der **SOAP-Kommunikation über HTTP**
- Kenntnis typischer SOAP-Attribute wie `[WebService]`, `[WebMethod]`
- Anwendung objektorientierter Prinzipien in Webmethoden

### Feinlernziele
- Projektstrukturierung in `.sln`, `.csproj`, `Webservice.cs`
- Einsatz von Methoden wie `BerechneAngebot`, `ErstelleAuftrag`
- Debugging und Testen von Webmethoden via SOAP-UI oder Browser

---

## Didaktische Fragen

### Offene Fragen
- „Was unterscheidet SOAP von REST?“  
- „Wie läuft die Kommunikation zwischen Client und Server ab?“  
- „Wie verändert sich die Struktur bei mehreren Webmethoden?“  

### Geschlossene Fragen
- „Ist SOAP zustandslos?“ → Ja/Nein  
- „Müssen Methoden mit `[WebMethod]` markiert sein?“ → Ja/Nein  
- „Lässt sich ein SOAP-Service mit VS Code hosten?“ → Ja/Nein  

---

## Arbeitsmittel

- Visual Studio Code / .NET SDK 8
- Projektdateien inkl. `.csproj`, `.sln`, `Webservice.cs`
- Beispiel-Datenstrukturen und XML-Schnittstellen
- SOAP-Testtools (z. B. Postman, SOAP-UI)

---

## Erfolgskontrolle

Der Teilnehmer:

- Startet den Webservice lokal (Konsolenanwendung oder IIS Express)
- Führt Webmethoden über SOAP-Client korrekt aus
- Erläutert die SOAP-Kommunikationsschritte
- Erkennt Unterschiede zu REST & versteht die XML-Spezifikationen

---

## 📂 Projektstruktur

```bash
SoapWebserviceProjekt/
├── Program.cs                       # Einstiegspunkt für Konsolen-Host
├── Webservice.cs                    # SOAP Methoden: Angebote, Aufträge
├── SoapWebserviceProjekt.csproj     # Projektdatei
├── bin/                             # Build-Output
├── obj/                             # Build-Zwischendateien
├── .vscode/                         # VS Code spezifische Einstellungen
├── README.md                        # Diese Datei
└── .gitignore                       # Ausschlussregeln für Git

````
---

## 📫 Kontakt

Fragen oder Feedback?  
**Doniman F. Peña Parra**

- 🌐 [GPT-Link zur Projektunterstützung](https://chatgpt.com/g/g-67f2ec205b0c819181790826b6abdad6-tutor-fur-betriebliche-informationssysteme)
- 🌐 [GPT-Link zur Projektunterstützung](https://chatgpt.com/g/g-gHoshJs8N-oop)
- 🔗 [LinkedIn-Profil ansehen](https://www.linkedin.com/in/doniman-francisco-pe%C3%B1a-parra-609263232/)
- 📧 E-Mail: [dofp79@hotmail.com](mailto:dofp79@hotmail.com)

---





