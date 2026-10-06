# PVA Rent A Car 

# Gemaakt door:

## [Wiebe](https://github.com/Wiebe-G)
## [Marc](https://github.com/Witzy0)
## [Stijn]

# Inhoud
Gemaakt door: Wiebe


## [Inleiding](#inleiding)
## [Rolverdeling](#rolverdeling)
## [Opdrachtsbeschrijving](#opdrachts-beschrijving)
## [Functioneel ontwerp](#functioneel-ontwerp)
## [Technisch ontwerp](#technisch-ontwerp)
## [Doelen](#doelen)
## [Risico's en maatregelen](#risico)
## [Wiebe's User Stories en ERD](#wiebe-erd)
## [Marc's User Stories en ERD](#marc-erd)
## [Stijn's User Stories en ERD](#stijn-erd)


## Inleiding
Gemaakt door: Marc

Rent a Car is een autoverhuurbedrijf met twee nieuwe eigenaren: Laura Beekman en Mark van Tessel.
Ze willen het bedrijf moderniseren en een premium autoverhuurder worden. Nu gaat veel nog op papier,
maar dat willen ze veranderen. Hierin staat wat de applicatie moet kunnen, de user stories, het ERD
en het bouwen van de applicatie.


## Rolverdeling
Gemaakt door: Wiebe

Wiebe: Beheerder  
Marc: Medewerker  
Stijn: Klant  


## Opdrachts beschrijving
Gemaakt door: Stijn
blah blah blah doe maar wat


## Functioneel ontwerp
 Gemaakt door: Marc

**Gebruikers**
- klant: registreert, reserveert, beheert eigen reserveringen en facturen
- Medewerkers: kan klanten invoeren en werkt met het dagoverzicht
- Beheerder: beheert alles en ziet de rapportages

**Klanten**
- Registreren met NAW-gegevens, een uniek e-mailadres en een wachtwoord
- Inloggen
- Status: Actief ( mag reserveren), Gepauzeerd (mag inloggen, niet reserveren), 
  Beëindigd (mag niet meer inloggen)
- Beheerders zien en wijzigen alle klantgegevens

**Wagenpark** 
- Overzicht met merk, model, kenteken, type, dagprijs en status 
  (beschikbaar, verhuurd, in onderhoud, buiten gebruik)
- Auto's toevoegen, bewerken en buiten gebruik zetten
- Een auto verwijderen mag niet als er nog toekomstige reserveringen zijn

**Instellingen** 
- Openingstijden per dag instellen
- Ophalen en terugbrengen alleen binnen die tijden
- Extra's beheren (navigatie, kinderstoeltje, luxe-pakket)
- Nieuwe prijzen gelden alleen voor nieuwe reserveringen

**Reserveren**
- Klant kiest auto, startdatum en einddatum
- Systeem toont welke auto's beschikbaar zijn en controleert dit
- Niet toegestaan: in het verleden, auto al verhuurd, buiten openingstijden,
  meer dan één jaar vooruit
- Klant kan reserveringen bekijken, wijzigen (met nieuwe controle) en annuleren tot 24 uur vooraf
- Automatisch dagoverzicht van reserveringen voor beheerder en de medewerkers

**Facturatie** 
- Na een reservering maakt het systeem automatisch een factuur en toont die
- Op de factuur: naam klant, uniek factuurnummer, periode, alle reserveringen in die periode,
  kosten per reservering en totaalbedrag
- Factuur opslaan als PDF of printen
- Klanten kunnen alleen hun eigen facturen openen en downloaden

**Dashboard**
- Aantal reserveringen per maand
- Omzet per maand
- Meest verhuurde auto's
- Bezettingsgraad
- Overzicht van terugkerende klanten


## Technisch ontwerp
Gemaakt door: Wiebe 

### Tech stack
	- C#
	- MySQL 
	- Git en github
### Omschrijving
Het moet een C# winforms applicatie worden die data ophaalt uit een mysql database.  
De frontend moet informatie over auto's ophalen uit die mysql database, 
en dan in de forms laten zien.  
### Rollen
	- Klant: 
		- Een klant moet auto's alleen kunnen bekijken.
	- Medewerker:
		- Medewerkers en beheerders moeten CRUD-operaties kunnen uitvoeren op auto's.
	- Beheerder:
		- Beheerder moet openingstijden kunnen instellen per dag.
		- Beheerder moet alles kunnen doen wat medewerkers kunnen
### Factuur
Factuur moet aangemaakt worden en een pdf invoice maken met QuestPDF library.  
Factuur moet dan in mysql worden opgeslagen.  
Factuur moet een ID krijgen, willekeurige reeks van 8 karakters (a-z, A-Z, 0-9, en '!' etc)

### Beveiliging
Gebruikers moeten alleen bij hun eigen data kunnen.
Wachtwoorden hashen met bcrypt
Bevestiging bij aanpassen of verwijderen gegevens.


## Doelen 
Gemaakt door: Stijn
tekst


## Risico 
Gemaakt door: Wiebe
| Risico | Gevolg | Maatregel |
|:--:|:--:|:--:|
| Merge conflict | Programma stopt met werken | Aparte branches voor iedereen
| Afwezigheid vanwege ziekte | Persoon kan werk mogelijk niet doen | Persoon toch het werk laten doen
| Gebrek aan communicatie in het team | Mensen werken niet aan de juiste taak | Stand-up op dinsdag en vrijdag 's ochtens
| Onvoldoende tijd besteed aan testen | Programma werkt niet | Automatische tests maken in github en in c# met bijv. xunit
| Achterlopen op de planning | Het project is mogelijk niet op tijd af | Samen kijken waarom we achterlopen en het oplossen


## Wiebe erd

### User Stories
Zet hier user stories in een tabel

### Acceptance Criteria
Acceptence criteria, ook in een tabel 

### Definition of Done 
Zet hier je definition of done, in een lijst

### Normalisatie
Normaalvormen

### ERD
ERD maken in [iets als dit](https://draw.io) en dan screenshot maken


## Marc ERD

### User Stories

| Titel | User story | Prio |
|:--|:--|:--:|
| Inloggen | Als medewerker wil ik kunnen inloggen met mijn e-mailadres en wachtwoord, zodat alleen ik bij de medewerkersfuncties kan | M |
| Klant invoeren | Als medewerker wil ik een nieuwe klant kunnen invoeren met NAW-gegevens en e-mailadres, zodat klanten die niet zelf registreren toch een account hebben | M |
| Klant zoeken | Als medewerker wil ik klantgegevens kunnen opzoeken en bekijken, zodat ik klanten snel kan helpen aan de balie | M |
| Wagenpark bekijken | Als medewerker wil ik een overzicht van het wagenpark kunnen zien (merk, model, kenteken, type, dagprijs, status), zodat ik weet welke auto's beschikbaar zijn | M |
| Auto toevoegen | Als medewerker wil ik een auto kunnen toevoegen, zodat nieuwe auto's in het systeem staan | M |
| Auto bewerken | Als medewerker wil ik een auto kunnen bewerken, zodat de gegevens en de status kloppen | M |
| Auto buiten gebruik zetten | Als medewerker wil ik een auto buiten gebruik kunnen zetten, zodat die niet meer gereserveerd kan worden | M |
| Waarschuwing bij verwijderen | Als medewerker wil ik een waarschuwing krijgen als ik een auto met toekomstige reserveringen wil verwijderen, zodat er geen reserveringen verloren gaan | S |
| Bevestiging | Als medewerker wil ik een bevestiging krijgen voordat ik gegevens wijzig of verwijder, zodat ik niet per ongeluk iets kwijtraak | S |
| Dagoverzicht | Als medewerker wil ik het dagoverzicht van reserveringen kunnen zien, zodat ik weet welke auto's die dag worden opgehaald en teruggebracht | M |
| Openingstijden bekijken | Als medewerker wil ik de openingstijden kunnen bekijken, zodat ik weet wanneer ophalen en terugbrengen kan | C |

### Acceptance Criteria
| User story | Prio | Acceptance criteria |
|:--|:--:|:--|
| Inloggen | M | Medewerker kan inloggen met e-mailadres en wachtwoord. Bij foute gegevens komt er een foutmelding. Medewerker ziet alleen medewerkersfuncties. |
| Klant invoeren | M | Medewerker kan een klant aanmaken met NAW-gegevens en e-mailadres. Een e-mailadres dat al bestaat wordt geweigerd. Verplichte velden moeten ingevuld zijn. |
| Klant zoeken | M | Medewerker kan klanten zoeken op naam of e-mailadres. Medewerker ziet de klantgegevens en de status. |
| Wagenpark bekijken | M | Medewerker kan het wagenpark bekijken met merk, model, kenteken, type, dagprijs en status. |
| Auto toevoegen | M | Medewerker kan een auto toevoegen. Een kenteken dat al bestaat wordt geweigerd. Auto staat daarna direct in het overzicht. |
| Auto bewerken | M | Medewerker kan gegevens en status van een auto aanpassen. Bevestiging popup als de wijziging wordt opgeslagen. |
| Auto buiten gebruik | M | Medewerker kan een auto buiten gebruik zetten. Die auto kan dan niet worden verhuurd. |
| Waarschuwing verwijderen | S | Medewerker krijgt een waarschuwing bij een auto met toekomstige reserveringen. Die auto kan dan niet worden verwijderd. |
| Bevestiging | S | Bij wijzigen of verwijderen komt een bevestiging popup. Bij "Nee" blijft alles hetzelfde. |
| Dagoverzicht | M | Medewerker kan de reserveringen van vandaag zien. Per reservering staan klant, auto en ophaal of terugbrengmoment erbij. |
| Openingstijden | C | Medewerker kan de openingstijden bekijken. Medewerker kan ze niet aanpassen. |

### Definition of Done 
- Het werkt zoals afgesproken (alle punten van de user story zijn gedaan).
- Het is getest door mijzelf en anderen.
- Bij verwijderen of aanpassen komt er eerst een "weet je het zeker?".
- Alleen de een ingelogde admin kan erbij
- De code is nagekeken door iemand anders (of samen bekeken).
- Er staan geen bekende fouten meer open.
- Het staat klaar op de testomgeving en is even getoond aan de rest.

### Normalisatie
Normaalvormen

### ERD
ERD maken in [iets als dit](https://draw.io) en dan screenshot maken


## Stijn ERD 
### User Stories
Zet hier user stories in een tabel

### Acceptance Criteria
Acceptence criteria, ook in een tabel 

### Definition of Done 
Zet hier je definition of done, in een lijst

### Normalisatie
Normaalvormen

### ERD
ERD maken in [iets als dit](https://draw.io) en dan screenshot maken