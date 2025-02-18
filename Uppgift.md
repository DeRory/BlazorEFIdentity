Bankuppgift

1.Skapa properties för användare (i ApplicationUser, kan ha flera konton)
2. Skapa klass för konto (Ny klass - kan ha flera transkationer, tillhör en användare)
3. Skapa klass för transkationer (ny klass, tillhör ett account)

4. Skapa även DBset i Dbcontext

5. Migrera och uppdatera DB

6. Skapa en profilsida för användaren (Det finns en boilerplate, modifiera den, använd bootstrap)
7a. Skapa en admin-sida (Behörighetslåst till admins. Ska kunna visa lista av användare).

7b. Skapa funktion att ta bort/lägga till roller för användare.

7. Skapa en admin-sida (Behörighetslåst till admins med funktioner kopplade till Kontoadmin t.ex. funktion att ta bort/lägga till roller för användare)

8. Account-Page
Skapa bank konton, kunna ha ett namn på den, vad för saldo det är, vilken slags konto typ det är (Om det ex. ISK konto, sparkonto etc), 
vi ska kunna ha en lista av transaktioner, vi vill även kunna se om kontot är aktiv eller och dess konto nummer

+ LÅSA KONTO


Skapa klass, lägg UserManager, (För transaktioner och olika typer av konton)


Services folder
EF Core, spara data, userManager för att hämta användaren som är inloggad, 
Skapa en formulär, struktur, 

NY service mapp, i den en .cs fil som är en klass, BankAccountService, och i den så vill man ha 3 dependecies eller två, EF (en db context) och en db manager, 
2 properties och har samma typ som dbcontext och userManager, Och i konstruktorn tilldelar jag de properties, props från kontruktor ta in usermanager och db
    skapa funktion set acc to user, ta in en parameter setbankaccount to user.


9. Jag vill skapa en sida som: överförar pengar till olika konton som användaren kan välja.
Och i den sidan vill jag kunna se transaktionshistoriken, allt från från vem pengar skickades till, och till vem. Vilken tid och datum det skedde. 
Hur mycket saldot var. Vilken valuta. Samt vill jag se meddelande om användaren har skrivit det. Och alla transaktioner ska ha ett nummer.














Vi ska använda Blazor, Identity, EF, Behörighetskrav, Autentisering och aukterisering. etc.


