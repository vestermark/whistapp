#UWP App
###Vi skal nu lave en UWP app som skal kalde Api App og presenterer en liste af puljer
_ _ _
1)  Åben **``Visual Studio 2016``**

_ _ _

2) Åben **Whistregnskab** solution fra tidligere ([Azure Api App](../Vejledning/ApiApp.md)).

_ _ _

3) Tilføj et nyt projekt til soulution.

![](https://4duwp.blob.core.windows.net/wiki/UWPApp1.PNG)

- Benyt følgende template: Hamburger (Template10)
- Kald projektet: Whistregnskab_UWP

![](https://4duwp.blob.core.windows.net/wiki/UWPApp2.PNG)

- Behold **``Location``**, så projektet bliver en den af den samlede solution.

_ _ _

4) Maker projektet **``Set as StartUp Project``**

_ _ _

5) Kør projektet på **``Local Machine``** (husk at vælge **x86** i stedet for **Any CPU**).

![](https://4duwp.blob.core.windows.net/wiki/UWPApp3.PNG)

- og luk det igen.

_ _ _

6) På grund af en fejl i Intellisense, så vil der i **Error List** vinduet

![](https://4duwp.blob.core.windows.net/wiki/UWPApp4.PNG)

	optræde voldsomt mange fejl

![](https://4duwp.blob.core.windows.net/wiki/UWPApp5.PNG)

	men det er en fejl. Luk solution og åben den igen, så vil disse fejl forsvinde i Error List. (Dette er en work-around - men det løser problemet).

![](https://4duwp.blob.core.windows.net/wiki/UWPApp6.PNG)

_ _ _

7) Åben **``Manage NuGet Packages``** under **References** på projektet, og vælg **Updates**

Det er vigtigt, at du undlader at opdaterer **Microsoft.Xaml.Behaviors.Uwp.Managed** (Der en en fejl i Template10 lige nu). Vælg ellers altid den nyeste version - og klik **``Update``**

![](https://4duwp.blob.core.windows.net/wiki/UWPApp7.PNG)

_ _ _

8) Vælg **Browse** og søg efter **azure mobile**

og installer seneste version af **Microsoft.Azure.Mobile.Client**

![](https://4duwp.blob.core.windows.net/wiki/UWPApp8.PNG)

_ _ _

9) Integrer [**MVVMLight**](../../XAML/Vejledning/MVVMLibs.md)

_ _ _

10) Tilføj en ny klasse i **Models** folderen

![](https://4duwp.blob.core.windows.net/wiki/UWPApp9.PNG)

11) Kald klassen **Pulje**

![](https://4duwp.blob.core.windows.net/wiki/UWPApp10.PNG)

12) Den skal arve fra **BindableBase** fra **Template10.Mvvm** namespace

![](https://4duwp.blob.core.windows.net/wiki/UWPApp11.PNG)

13) For hver attribute (felt) fra tabellen, skal der oprettes en property. Denne skal følge nedestående mønster:

![](https://4duwp.blob.core.windows.net/wiki/UWPApp12.PNG)

14) Gentag nu således at du har følgende properties:

	- PuljeId (int)
	- Navn (string)
	- Ejer (string)
	- Oprettet (DateTime)
	- Spiller1 (string)
	- Point1 (int)
	- Spiller2 (string)
	- Point2 (int)
	- Spiller3 (string)
	- Point3 (int)
	- Spiller4 (string)
	- Point4 (int)
_ _ _

15) Tilføj et interface **IWhistApi** under en ny folder **WhistApi** under folderen **Services**

![](https://4duwp.blob.core.windows.net/wiki/UWPApp13.PNG)

16) Det skal have følgende indhold

![](https://4duwp.blob.core.windows.net/wiki/UWPApp14.PNG)

_ _ _

17) Tilføj en klasse **WhistApi** under folderen **WhistApi** med følgende indhold

![](https://4duwp.blob.core.windows.net/wiki/UWPApp15.PNG)

_ _ _

18) Juster **ViewModelLocator.cs**, tilføj denne linie som giver dependency injector kendskab til **IWhistApi** og **WhistApi**

![](https://4duwp.blob.core.windows.net/wiki/UWPApp16.PNG)

_ _ _

19) Juster **ViewModelLocator.cs**, tilføj denne linie som giver dependency injector kendskab til **IWhistApi** og **WhistApi**

![](https://4duwp.blob.core.windows.net/wiki/UWPApp16.PNG)

_ _ _

20) Juster **MainPageViewModel.cs**

- tilføj en private variable af typen **IWhistApi**
- Ændre constructor, så den modtager en parameter af type **IWhistApi** og sætter den lig den lokale variable.

![](https://4duwp.blob.core.windows.net/wiki/UWPApp17.PNG)

- fjern property **Value** og alle linier som refererer hertil
- fjern metoden **GotoDetailsPage**

_ _ _

21) Opret en property **Puljer**, som er en generisk **ObservableCollection** af typen **Pulje**

![](https://4duwp.blob.core.windows.net/wiki/UWPApp18.PNG)

_ _ _

22) I metoden **OnNavigatedToAsync** populeres propertien **Puljer** med et kald af metoden **HentPuljer** fra **_whistApi** servicen

![](https://4duwp.blob.core.windows.net/wiki/UWPApp19.PNG)

_ _ _

23) Indsæt XAML med databinding i **MainPage.XAML**

- Fjern element: <controls:Resizer...
- Fjern element: <Button x:Name="submitButton"...
- Fjern element: <TextBlock x:Name="statsTextBox"...
- Fjern element: <Setter Target="stateTextBox.Text" Value="Narrow Visual State"...  for alle 3 visual states
- Ret <controls:Pageheader... sæt Text="Puljeliste"
- Placer et nyt element under: </controls:PageHead..

![](https://4duwp.blob.core.windows.net/wiki/UWPApp20.PNG)

_ _ _

24) Kør app'en

![](https://4duwp.blob.core.windows.net/wiki/UWPApp21.PNG)

_ _ _

24) Ved at indsætte en <?.ItemsTemplate..., så kan man kontrollerer hvorledes det enkelte element vises

![](https://4duwp.blob.core.windows.net/wiki/UWPApp22.PNG)

_ _ _

25) Så kan man få det til at se lidt bedre ud...

![](https://4duwp.blob.core.windows.net/wiki/UWPApp23.PNG)

_ _ _















