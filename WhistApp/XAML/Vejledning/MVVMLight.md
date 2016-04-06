#MvvmLightLibs

Hvis du ønsker at benytte MVVM light i et **Hamburger (Template10)** projekt, så kan du her finde en vejledning til hvorledes du kan integrerer det.

1) Åben **``Manage NuGet Packages``** under **References** på projektet, og vælg **Browse** og søg efter **mvvm**

![](/Images/MVVMLibs1.PNG)

og installer seneste version af **MvvmLightLibs**.

_ _ _

2) Indsæt en ny klasse **ViewModelLocator** i **ViewModels** folderen.

![](/Images/MVVMLibs2.PNG)

_ _ _

3) Tilret **App.XAML**

![](/Images/MVVMLibs3.PNG)

_ _ _

4) Gentag for alle views med data: **5) og 6)**

_ _ _

5) Tilret **?Page.XAML** i **Views** folderen

- fjern **<Page.DataContext...** blokken
- indsæt en **DataContext** som attribute i Page elementet

![](/Images/MVVMLibs4.PNG)

_ _ _

6) Hvis du ønsker at bruge x:Bind (og det gør vi... :-)), så skal der arbejdes typestærkt. På Page niveau er DataContext ikke typestærkt, så derfor benyttes nedenstående trick i code-behind. Vi kan herefter henvise til "ViewModel" for at få en typestærk reference til vores DataContext.

![](/Images/MVVMLibs6.PNG)

_ _ _




