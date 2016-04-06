#Api app
####Vi skal nu lave en Api App i Azure, som skal fungerer som bindeled mellem App og database. 
_ _ _
1)  Åben Visual Studio og opret et nyt Web projekt

![](https://4duwp.blob.core.windows.net/wiki/ApiApp1.PNG)

Bemærk Name = **WhistregnskabApiApp** og Solution Name = **Whistregnskab**
_ _ _

2) Vælg **Azure Api App** template, som skal hostes "in the cloud".

![](https://4duwp.blob.core.windows.net/wiki/ApiApp2.PNG)

_ _ _

3) Udfyld **WhistregnskabApiApp** som Api App Name, vælg **WhistregnskabRG** som Resource Group og tryk **``New...``** under App Service Plan

![](https://4duwp.blob.core.windows.net/wiki/ApiApp3.PNG)


4) Behold **WhistregnskabApiAppPlan**, sæt location til **West Europe** og Size til **Free**.

![](https://4duwp.blob.core.windows.net/wiki/ApiApp4.PNG)

_ _ _

5) Slet **ValuesController** under **Controllers**.

![](https://4duwp.blob.core.windows.net/wiki/ApiApp5.PNG)

_ _ _

6) Og opret en ny controller

![](https://4duwp.blob.core.windows.net/wiki/ApiApp6.PNG)

_ _ _

7) Vælg **Web Api 2 Controller - empty**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp7.PNG)

_ _ _

8) Og giv den navnet **HentPuljerController**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp8.PNG)

_ _ _

9) Under **Models** folderen, oprettet en ny **ADO.NET Entity Data Model** som du kalder **WhistregnskabModel**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp9.PNG)

_ _ _

10) Vælg **Code First from database**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp10.PNG)

_ _ _

11) Opret **New Connection** til serveren som vi skabte under [OpretDatabase](OpretDatabase.md) - husk at vælge **Whistregnskab** databasen.

![](https://4duwp.blob.core.windows.net/wiki/ApiApp11.PNG)

_ _ _

12) Marker **Yes, include the sensitive...** og tryk **``Next``**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp12.PNG)

_ _ _

13) Vælg tabellen **Puljer** , fjern markering under **Pluralize og singularize generated object names** og tryk **``Finish``** 

![](https://4duwp.blob.core.windows.net/wiki/ApiApp13.PNG)

_ _ _

14) Rebuild projektet.

_ _ _

15) Omdøb klassen **Puljer** under **Model** til **Pulje**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp15.PNG)

_ _ _

16) Skab en metode i **HentPuljerController**, som hedder **GetPuljer**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp14.PNG)

_ _ _

17) Åben **NuGet Package Manager**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp19.PNG)

_ _ _

18) Opdater alle pakker til nyeste version

![](https://4duwp.blob.core.windows.net/wiki/ApiApp18.PNG)

_ _ _

19) Kør projektet i **Microft Edge**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp16.PNG)

_ _ _

20) forlæng URL med **/swagger** og prøv igen

![](https://4duwp.blob.core.windows.net/wiki/ApiApp17.PNG)

_ _ _

21) Prøv at hent data ved at vælge **HentPuljer** - **``Get``** - **``Try it out!``**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp20.PNG)

_ _ _

22) Publiser projektet til Azure

![](https://4duwp.blob.core.windows.net/wiki/ApiApp21.PNG)

23) Tryk **``Publih``**

![](https://4duwp.blob.core.windows.net/wiki/ApiApp22.PNG)

og test igen med **/swagger**

Projektet er nu publiseret til Azure :-)

_ _ _













