<img src='https://unikum.se/media/1351/lo_ab_dh_solutions_ny.png?v=636262818484188877'></img>


Av Mattias Arnesson


<h1>Arbetstest</h1>


<h2>Produkt</h2>
Ett litet projekt gjort på 2-3 timmar. Produkten är en hemsida där man har en visuell lista på spel och olika attribut för dessa spelet. Man kan skapa, redigera, se och radera spelen. Attributen är så som titel, beskrivning mm.

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


Därav följde jag konceptet "database first" och efter de skapade jag en modell och implementerade en controller för sjävla API:et. Relativ långt tid lades ner på API:ET. Då det var längesen jag jobbade just med API:ER i ASP.NET. Jag stötte snabbt på fel och körde ett antal tester i PostMan för att diagnosiera felen. Efter detta löste jag problemen och kunde gå vidare till att utveckla hemsidan. 

Hemsidan utvecklade jag precis som vilken hemsida som helst och gjorde det väldigt basic

<h2>Förbättringar & Diskussion</h2>
