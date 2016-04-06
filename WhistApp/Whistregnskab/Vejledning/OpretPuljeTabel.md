#Opret tabel
Efter vi har oprettet vores database, så skal vi nu have oprettet den første tabel i databasen. Vi skal burge den som stamtabel for Puljer i vore app.

##Udførlig vejledning

1)  Åben **``SQl Server Management Studio 2016``** og login på database serveren:

![](/Images/NewDatabase6.PNG)

_ _ _

2) Første gang du logger ind på database serveren, så vil dens firewall nægte dig adgang. Du vil så få mulighed for at logge ind som administrator og her kan du åbne firewall for din IP-Adresse.

![](/Images/NewDatabase7.PNG)

_ _ _

3) Opret en ny tabel under **``Whistregnskab``** databasen

![](/Images/NewDatabase8.PNG)

_ _ _

4) Angiv følgende skema for tabellen:

![](/Images/NewDatabase9.PNG)

husk at angive **PuljeId** som den primære nøgle, og sætte **``Identity Specification``** til Incerment=1 og Seed=1

_ _ _

5) Når du trykker på krydset for fanen, så bliver du promptet for om du vil gemme tabellen

![](/Images/NewDatabase10.PNG)

og her trykker du på **``Yes``**

_ _ _


6) Og her skriver du navnet på tabellen: **Puljer**

![](/Images/NewDatabase11.PNG)

Og gemmer med **``OK``**

_ _ _

7) Rediger tabellen

![](/Images/NewDatabase12.PNG)

_ _ _

7) Og indtast 2-3 nye puljer. Husk at undlade og skrive noget i PuljeId som jo er Identity kolonner (AutoIncrement).

![](/Images/NewDatabase13.PNG)











