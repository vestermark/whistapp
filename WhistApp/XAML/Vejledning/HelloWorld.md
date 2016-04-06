#Hello world

Dette er den første UWP app vi laver.



####1) Start Visual Studio 2015

- - -

####2) Create new Project

![](/Images/HelloWorld0.PNG)

Vælg "Blank" template og kald projektet **HelloWorld**

![](/Images/HelloWorld1.PNG)

- - -

####3) MainPage.xaml

Find <Grid... elementet og erstat det med nedenstående

```

    <Grid Margin="12">
        <TextBlock x:Name="tbHello" Text="Hello world!" Style="{StaticResource HeaderTextBlockStyle}"/>
    </Grid>
    
```

- - -

####4) App.xaml

Udkommenter blokken som giver en framerate-counter i øverste venstre hjørne

![](/Images/HelloWorld2.PNG)

- - -

####5) Run

Kør app'en ved tryk på **``F5``**

![](/Images/HelloWorld3.PNG)

Du kan vælge og kører app'en på andre platforme ved at vælge

![](/Images/HelloWorld3a.PNG)

Simulator

![](/Images/HelloWorld4.PNG)

Mobile (1080p) (Her skal du dog lige lave forgrundsfarven om til hvid)

![](/Images/HelloWorld5.PNG)


