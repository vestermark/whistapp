#UWP App
###Vi skal nu lave en UWP app som skal kalde Api App og presenterer en liste af puljer

Vi tilføjer en ny UWP app til vores solution fra tidligere. Denne skal være baseret på Hambuger (Template10) templaten og benytte MvvmLight. Vi tilføjer en Model-klasse, som skal representerer Pulje, der skal hentes ved et servicekald fra Whistregnskab Api App. Vi presenterer data med en LsitView kontrol på MainPage.xaml.


##Udførlig vejledning:

1)  Åben **``Visual Studio 2015``**

_ _ _

2) Åben **Whistregnskab** solution fra tidligere ([Azure Api App](../Vejledning/ApiApp.md)).

_ _ _

3) Tilføj et nyt projekt til soulution (Højerklik på solution navn og vælg **``Add``**).

![](/Images/UWPApp1.PNG)

- Benyt følgende template: **``C#``** - **``Windows``** - **``Universal``** - **``Template10``** - **``Hamburger``**
- Projekt navn: *Whistregnskab_UWP**

![](/Images/UWPApp2.PNG)

- Behold **``Location``**, så projektet bliver en den af den samlede solution.

Hvis der er et check i Add Application Inside, så husk at fjerne det

![](/Images/UWPApp24.PNG)

_ _ _

4) Maker projektet **``Set as StartUp Project``**

_ _ _

5) Kør projektet på **``Local Machine``** (husk at vælge **x86** i stedet for **Any CPU**).

![](/Images/UWPApp3.PNG)

- og luk det igen.

_ _ _

6) På grund af en fejl i Intellisense, så vil der i **Error List** vinduet

![](/Images/UWPApp4.PNG)

	optræde voldsomt mange fejl

![](/Images/UWPApp5.PNG)

men det er en fejl. Luk solution og åben den igen, så vil disse fejl forsvinde i Error List. (Dette er en work-around - men det løser problemet).

![](/Images/UWPApp6.PNG)

_ _ _

7) Åben **``Manage NuGet Packages``** under **References** på projektet, og vælg **Updates**

Det er vigtigt, at du undlader at opdaterer **Microsoft.Xaml.Behaviors.Uwp.Managed** (Der en en fejl i Template10 lige nu). Vælg ellers altid den nyeste version - og klik **``Update``**

![](/Images/UWPApp7.PNG)

_ _ _

8) Vælg **Browse** og søg efter **azure mobile**

og installer seneste version af **Microsoft.Azure.Mobile.Client**

![](/Images/UWPApp8.PNG)

_ _ _

9) Du skal nu implementerer MvvmLight i vores UWP projekt. Følg dette link :Integrer [**MVVMLight**](/XAML/Vejledning/MVVMLight.md) for at finde en generel vejledning for MvvmLight til et Template10 projekt.

_ _ _

10) Tilføj en ny klasse i **Models** folderen

![](/Images/UWPApp9.PNG)

11) Kald klassen **Pulje**

![](/Images/UWPApp10.PNG)

12) Den skal arve fra **BindableBase** fra **Template10.Mvvm** namespace

![](/Images/UWPApp11.PNG)

13) For hver attribute (felt) fra tabellen, skal der oprettes en egenskab. Denne skal følge nedestående mønster:

![](/Images/UWPApp12.PNG)

14) Dette mønster gentages, således at du får en klasse med følgende egensksaber:

Egenskab | Type
----- | -----
PuljeId | int
Navn | string
Ejer | string
Oprettet | DateTime
Spiller1 | string
Point1 | int
Spiller2 | string
Point2 | int
Spiller3 | string
Point3 | int
Spiller4 | string
Point4 | int
_ _ _

15) Tilføj et interface **IWhistApi** under en ny folder **WhistApi** under folderen **Services**

![](/Images/UWPApp13.PNG)

16) Det skal have følgende indhold

![](/Images/UWPApp14.PNG)

_ _ _

17) Tilføj en klasse **WhistApi** under folderen **WhistApi** med følgende indhold

![](/Images/UWPApp15.PNG)

_ _ _

18) Juster **ViewModelLocator.cs**, tilføj denne linie som giver dependency injector kendskab til **IWhistApi** og **WhistApi**

![](/Images/UWPApp16.PNG)

_ _ _

19) Juster **MainPageViewModel.cs**

- tilføj en private variable af typen **IWhistApi**
- Ændre constructor, så den modtager en parameter af type **IWhistApi** og sætter den lig den lokale variable.

![](/Images/UWPApp17.PNG)

- fjern property **Value** og alle linier som refererer hertil
- fjern metoden **GotoDetailsPage**

_ _ _

20) Opret en property **Puljer**, som er en generisk **ObservableCollection** af typen **Pulje**

![](/Images/UWPApp18.PNG)

_ _ _

21) I metoden **OnNavigatedToAsync** populeres propertien **Puljer** med et kald af metoden **HentPuljer** fra **_whistApi** servicen

![](/Images/UWPApp19.PNG)

_ _ _

22) Indsæt XAML med databinding i **MainPage.XAML**

- Fjern element: <controls:Resizer...
- Fjern element: <Button x:Name="submitButton"...
- Fjern element: <TextBlock x:Name="statsTextBox"...
- Fjern element: <Setter Target="stateTextBox.Text" Value="Narrow Visual State"...  for alle 3 visual states
- Ret <controls:Pageheader... sæt Text="Puljeliste"
- Placer et nyt element under: </controls:PageHead..

![](/Images/UWPApp20.PNG)

_ _ _

23) Kør app'en

![](/Images/UWPApp21.PNG)

_ _ _

24) Ved at indsætte en <?.ItemsTemplate..., så kan man kontrollerer hvorledes det enkelte element vises

![](/Images/UWPApp22.PNG)

_ _ _

25) Så kan man få det til at se lidt bedre ud...

![](/Images/UWPApp23.PNG)

_ _ _















