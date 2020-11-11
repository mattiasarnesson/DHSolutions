<img src='https://unikum.se/media/1351/lo_ab_dh_solutions_ny.png?v=636262818484188877'></img>


Av Mattias Arnesson


<h1>Arbetstest</h1>


<h2>Produkt</h2>
Ett litet projekt gjort på 2–3 timmar. Produkten är en hemsida där man har en visuell lista på spel och olika attribut för dessa spelet. Man kan skapa, redigera, se och radera spelen. Attributen är så som titel, beskrivning mm.

<h2>Tillvägagångsätt</h2>
Projektet består av 2 komponenter som kommunicerar med varandra. Det är ett WEB-API samt en WEB-SERVER båda två gjorda i ASP.NET. Komponenterna använder sig av MVC. Andra verktyg/ramverk som har använts är WebAPI-client från Nugget för att kommunicera från klient till server samt Bootstrap för layout och de visuella. 

Jag började projektet genom att skapa ett en Databas samt en tabell som kunde hålla alla spelen. Definationen av denna tabell är följande:

>CREATE TABLE [dbo].[Games] (
>    [Id]            INT         IDENTITY (1, 1) NOT NULL,
>    [title]         NCHAR (30)  NOT NULL,
>    [desc]          NCHAR (500) NOT NULL,
>    [realease_year] DATE        NOT NULL,
>    [img_url]       NCHAR (500) NULL,
>    PRIMARY KEY CLUSTERED ([Id] ASC)
>);


Därav följde jag konceptet "database first" och efter de skapade jag en modell och implementerade en controller för själva API:et. Relativ långt tid lades ner på API:ET. Då det var längesen jag jobbade just med API:ER i ASP.NET. Jag stötte snabbt på fel och körde ett antal tester i PostMan för att diagnostisera felen. Efter detta löste jag problemen och kunde gå vidare till att utveckla hemsidan. 

Hemsidan utvecklade jag precis som vilken hemsida som helst och gjorde det väldigt basic. Den består av tre sidor. En som representerar listan med alla spel, en vy för att redigera och lägga till samt en detaljerad vy. 

<h2>Förbättringar & Diskussion</h2>

Om jag nu skulle vidareutveckla detta koncept/projekt...

1.* Bättre Client-side validering i alla input fields. Just nu använder jag bara grundläggande HTML Validation. Man hade kunnat använda JQuery Validation för att uppnå ännu bättre validering. 

2.* Server-side validering. Just nu finns den in princip ingen server side validation och ingen respons på ifall något går fel till klient.

3.* UX/UI Uppdatering. Hade kunnat göra gränssnitten mer användarvänligt. Tex när man tar väck ett föremål i listan så hade man kunnat på en varning först innan man tar väck den. Det hade jag då gjort med JS. 

4.* Filhantering. Man kan länka till en bild på spelfodralet. Det hade höjt komplexiteten av projektet ifall man kanske fick ladda upp en bild till tex Azure istället för att bara länka till en URL. 

5.* Rensat projekten. Jag startade projekten från MVC Standard Template. Jag hade kunnat rensa upp bättre i alla filer som ej används och imports osv. 

6.* Kommentarer. Nu har jag ej kommenterat koden då detta projekt var såpass litet att detta ej kändes nödvändigt. Men jag hoppas att detta dokument förklarar lite med ingående istället för kommentarer. 

Tack för mig, Mattias Arnesson
