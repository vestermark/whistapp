#Api app

Vi skal nu lave en service, som vi kan kalde for at administrere data i vore database. Denne service bygger vi i Azure som en Api App.
En Api App er en REST baseret service, som bygger på WebApi2 fra MVC. I første omgang skal den alene have en metode som kan afleverer en liste over alle puljer i databasen.

##Udførlig vejledning

1)  Åben Visual Studio og opret et nyt Web projekt

![](/Images/ApiApp1.PNG)

Bemærk Name = **WhistregnskabApiApp** og Solution Name = **Whistregnskab**

#####Husk at fjerne checkmark for Application Inside, der tilføjer en masse overvågning i din app. 

![](/Images/ApiApp24.PNG)

_ _ _

2) Vælg **Azure Api App** template, som skal hostes "in the cloud".

![](/Images/ApiApp2.PNG)

_ _ _

3) Udfyld **WhistregnskabApiApp** som Api App Name, vælg **WhistregnskabRG** som Resource Group og tryk **``New...``** under App Service Plan

![](/Images/ApiApp3.PNG)


4) Behold **WhistregnskabApiAppPlan**, sæt location til **West Europe** og Size til **Free**.

![](/Images/ApiApp4.PNG)

_ _ _

5) Slet **ValuesController** under **Controllers**.

![](/Images/ApiApp5.PNG)

_ _ _

6) Og opret en ny controller

![](/Images/wiki/ApiApp6.PNG)

_ _ _

7) Vælg **Web Api 2 Controller - empty**

![](/Images/ApiApp7.PNG)

_ _ _

8) Og giv den navnet **HentPuljerController**

![](/Images/ApiApp8.PNG)

_ _ _

9) Under **Models** folderen, oprettet en ny **ADO.NET Entity Data Model** som du kalder **WhistregnskabModel**

![](/Images/ApiApp9.PNG)

_ _ _

10) Vælg **Code First from database**

![](/Images/ApiApp10.PNG)

_ _ _

11) Opret **New Connection** til serveren som vi skabte under [OpretDatabase](OpretDatabase.md) - husk at vælge **Whistregnskab** databasen.

![](/Images/ApiApp11.PNG)

_ _ _

12) Marker **Yes, include the sensitive...** og tryk **``Next``**

![](/Images/ApiApp12.PNG)

_ _ _

13) Vælg tabellen **Puljer** , fjern markering under **Pluralize og singularize generated object names** og tryk **``Finish``** 

![](/Images/ApiApp13.PNG)

_ _ _

14) Rebuild projektet.

_ _ _

15) Omdøb klassen **Puljer** under **Model** til **Pulje**

![](/Images/ApiApp15.PNG)

_ _ _

16) Skab en metode i **HentPuljerController**, som hedder **GetPuljer**

![](/Images/ApiApp14.PNG)

_ _ _

17) Åben **NuGet Package Manager**

![](/Images/ApiApp19.PNG)

_ _ _

18) Opdater alle pakker til nyeste version

![](/Images/ApiApp18.PNG)

_ _ _

19) Kør projektet i **Microft Edge**

![](/Images/ApiApp16.PNG)

_ _ _

20) forlæng URL med **/swagger** og prøv igen

![](/Images/ApiApp17.PNG)

_ _ _

21) Prøv at hent data ved at vælge **HentPuljer** - **``Get``** - **``Try it out!``**

![](/Images/ApiApp20.PNG)

_ _ _

22) Publiser projektet til Azure

![](/Images/ApiApp21.PNG)

23) Tryk **``Publish``**

![](/Images/ApiApp22.PNG)

og test igen med **/swagger**

Projektet er nu publiseret til Azure :-)

_ _ _













