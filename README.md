# B2D4Oefenopdracht
Eisen:
- Losse componenten (projecten) voor GUI en back-end
- Communicatie via voor gedefinieerde interfaces
- Testproject (unittesten) voor het testen van de back-end

Opdrachtbeschrijving:
Sinterklaas is weer in het land en kerstmis is ook niet ver weg. Dat betekent dat het een drukke periode is voor mensen die cadeaus halen voor deze gelegenheden. Natuurlijk heeft iedereen zijn eigen cadeau-wensen en is het niet de bedoeling dat iemand 2x hetzelfde cadeau krijgt.

Om dit proces te versimpelen, wordt een programma ontwikkeld. Hierbij is het belangrijk dat de onderliggende logica een opzichzelfstaande library wordt. Voornamelijk zodat er (later) meerdere verschillende front-end applicaties eraan gekoppeld kunnen worden. Het idee is dat er uiteindelijk een web-, mobiele- en desktop-applicatie gebruikt gaat maken van deze library.

Een aantal wensen zijn hieronder (kort) beschreven. Deze kunnen naar wens verder uitgebreid en aangepast worden.
Er zijn 2 verschillende rollen binnen dit systeem: De cadeau-ontvanger (CO) en de cadeau-gever (CG). Een gebruiker kan op enig moment beide rollen aannemen, maar dit hoeft niet.

- Van een cadeau worden de volgende attributen opgeslagen:
  - Naam van het cadeau
  - Categorie van het cadeau. Dit kunnen meerdere categorieën zijn en een onderverdeling naar subcategorieën is gewenst (bijv: Gezelschapspellen -> Bordspellen
  - Welke winkel(s) deze gekocht kan worden (eventueel met links naar webshops)
  - Prijs of prijsrange van een cadeau (zou voor kinderen misschien ook in de vorm: klein, middel, groot cadeau kunnen zijn)
  - Afbeelding van het cadeau
  - Aantal gewenste producten (bijv: 2 bioscoopkaarten of 10 glazen)
- Een CO moet de mogelijkheid hebben om een wensenlijst te maken van cadeaus die hij/zij graag zou ontvangen.
- Binnen de applicatie kunnen groepen personen aangemaakt worden. Denk aan “gezin”, “collega’s”, enz. 
  - 1 gebruiker maakt de groep aan en heeft de mogelijkheid om andere mensen hieraan toe te voegen.
  - De maker van de groep kan selecteren of een gebruiker de rol van CO, CG of beide heeft.
- Een persoon kan in meerdere groepen zitten en in iedere groep een andere rol hebben.
- Een CO kan een eigen wensenlijst maken en/of per groep een verschillende wensenlijst creëren.
  - Als CO in een groep een andere wensenlijst wil maken, krijgt hij de mogelijkheid om eerdere wensen te selecteren uit zijn globale wensenlijst.
- Een CG moet kunnen zien welke cadeaus de verschillende CO’s op hun lijst hebben staan.
- Bij het tonen van de wensenlijst van een CO, moet het mogelijk zijn om te kunnen filteren op verschillende attributen zoals prijs en categorie.
- Een CG moet kunnen afvinken dat een cadeau gekocht is voor een bepaalde CO. Dit mag alleen getoond worden aan andere CG’s, niet aan de CO zelf.
