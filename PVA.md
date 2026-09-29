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
| Titel | User story | Prioriteit
|:--:|:--:|:--:|
| Registreren | Als beheerder wil ik accounts kunnen registreren, zodat medewerkers een account hebben met de juiste toegang | M
| Inloggen | Als beheerder wil ik kunnen inloggen, zodat ik veilig bij de nodige informatie kan | M
| Auto aanmaken | Als beheerder wil ik een auto kunnen aanmaken, zodat ik deze kan verkopen | M 
| Auto bekijken | Als beheerder wil ik een auto kunnen bekijken, zodat ik foutieve informatie kan zien en fixen | M 
| Auto bewerken | Als beheerder wil ik een auto kunnen aanpassen, zodat ik foutieve informatie kan verbeteren | M 
| AUto buiten gebruik zetten | Als beheerder wil ik auto's buiten gebruik kunnen zetten, zodat we geen kapotte auto's verhuren | M
| Auto verwijderen | Als beheerder wil ik een auto kunnen verwijderen, zodat ik oude modellen niet meer verkoop | maakt
| Factuur maken | Als beheerder wil ik een factuur kunnen maken, zodat ik de klant kan laten betalen | M 
| Factuur bekijken | Als beheerder wil ik facturen kunnen bekijken, zodat ik weet wie wel of niet betaald heeft | M 
| Factuur bewerken | Als beheerder wil ik facturen kunnen aanpassen, zodat ik mensen meer kan laten betalen | C
| Factuur verwijderen | Als beheerder wil ik facturen kunnen verwijderen, zodat ik belastingsfraude kan plegen | C
| Klanten bekijken | Als beheerder wil ik alle klanten kunnen zien, zodat ik weet wie bij ons koopt | M 
| Medewerkers bekijken | Als beheerder wil ik medewerkers kunnen inzien, zodat ik weet wie voor ons werkt | M 
| Voorraad inzien | Als beheerder wil ik zien welke auto's wel en niet zijn uitgeleend, zodat ik weet wat onze voorraad is | M
| Reserveringen/planning inzien | Als beheerder wil ik reserveringen inzien, zodat ik weet welke auto's we op voorraad hebben | M
| Prestatie dashboard | Als beheerder wil ik een prestatie dashboard, zodat ik kan zien welke medewerkers goed werken | M
| Openingstijden | Als beheerder wil ik openingstijden kunnen maken en aanpassen, zodat ik weet wanneer auto's opgehaald en ingeleverd mogen worden | M 

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
Zet hier user stories in een tabel

### Acceptance Criteria
Acceptence criteria, ook in een tabel 

### Definition of Done 
Zet hier je definition of done, in een lijst

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