#Windows installation

Her beskrives hvorledes du skaber en ny virtuel-pc i Azure, med Windows 10 (10586) og Visual Studio 2015 Update 1 præ-installeret. Det forudsætter, at du har et MSDN-abonnement for at kunne skabe denne virtuel-pc. Hvis det ikke er tilfældet, så vil der på din maskine hos 4D være en virtuel-pc, som allerede er sat korrekt op. Du kan dog ikke tage den med hjem efter kurset, og er således nød til at foretage installationen på en maskine hjemme. Det smarte med MSDN løsningen er, at du blot efterfølgende kan arbejde videre med alt hvad vi laver på kurset.


####1) Åben Azure portal på http://portal.azure.com

- - -

####2) Skab en ny virtual-pc.
Vælg **``New``** og skriv "visual studio update 1 1511" og tryk **``Enter``**

![](/Images/VPC1.PNG)

Vælg den ønskede version af Visual Studio 2015. Hvis du kan se en Exterprise, så vælg den.

![](/Images/VPC2.PNG)

Tryk **``Create``**

![](/Images/VPC3b.png)

Hvis du ikke har et MSDN-abonnement, så får du denne skærm frem

![](/Images/VPC4.PNG)

Udfyld punkterne under 1) Basics
- Navn på pc (dit eget interne navn): **Win10Dev**
- User name (Brugernavn som du ønsker at benytte til login): **developer**
- Password (Strong password som du kan huske): **P@ssw0rdDev**
- Resource Group (Ny resource group som du skaber): **Win10DevRG**
- Location (Hvor skal den virtuel-pc leve): **West Europe** (Det er ikke tilfældigt, at vi vælger "West Europe" som location for vores virtuel-pc. Det er nemlig et af de få Azure datacentre som kan håndterer den særligt type virtual mashine som vi ønsker.)
- tryk **``OK``**

![](/Images/VPC5.PNG)

Vælg **``View All``**

![](/Images/VPC6.PNG)

og klik på **``DS3 Standard``** og tryk **``Select``**

![](/Images/VPC7.PNG)

Tryk **``OK``** på fanen "3. Settings"

![](/Images/VPC8.PNG)

Og tryk **``OK``** på den sidste fane "4. Summary"

![](/Images/VPC9.PNG)

Azure vil nu gå i gang med at skabe din virtuelle maskine. Det tager omkring 10 minutter.

![](/Images/VPC10.PNG)

Når den er klar, så vil din "flise" se således ud

![](/Images/VPC11.PNG)

Læg mærke til at der står "Running", da den nu er i luften.
Klik på flisen og du vil komme til denne status fane

![](/Images/VPC12b.png)

Hvis du trykker **``Connect``**, så vil du downloade en profil til **Remote Desktop**. Vælg **``Open``**

![](/Images/VPC13.PNG)

Du skal nu logge ind med det user name/password som den bruger du angav lige før.
- læg mærke til at du skal skrive ".\" før user name for at angive at du vil logge på lokalt på maskinen.
 
![](/Images/VPC14.PNG)

Så er din virtuelle maskine i luften.

![](/Images/VPC15.PNG)

- - -

####3) Opdater din Windows 10

Tryk **``Windows-tast``** og vælg **``Settings``**

![](/Images/VPC16.PNG)

og vælg **``Update & security``**

![](/Images/VPC17.PNG)

og under **``Windows update``** vælger du **``Check for updates``**
- bemærk at du muligvis skal gennemfører denne process over en eller flere genstarter
- bliv ved til der ikke er mere i Windows Update at installerer

![](/Images/VPC18.PNG)
