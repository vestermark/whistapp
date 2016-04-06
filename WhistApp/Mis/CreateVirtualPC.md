#Virtual-PC

Vi skal bruge en virtual-pc, som der kan bruges som udviklings computer. Det smarte ved at lave den i Azure, er at den altid vil være tilgængelig og at der ikke stilles nogle krav til at jeres egen pc skal være opdateret til Windows 10.
Men dette kan kun lade sig gøre hvis du har et MSDN-abonnement. Alternativt så mu du opgraderer din egen maskine efter specifikationer herunder.

Vores arbejdscomputer skal være opbygget som nedenstående. Klik på det enkelte punkt for at få en step-by-step vejledning.


Emne | Beskrivelse
--- | ---
1. [Operativsystem](/Mis/CreateVirtualPC_Windows.md) | - **Windows 10 Enterprise - version 1511** (også kaldet version 10586)<br/>- Windows skal have installeret alle nye opdateringer i Windows Update<br/>- Window skal indstilles til **Developer mode**
2. [WebPlatform Installer](/Mis/CreateVirtualPC_WPI.md) | - **Microsoft Azure Powershell** i nyeste version (3/3/2016)<br/>- **Azure SDK .Net** (VS2015) i nyeste version (v2.8.2.1)
3. [SQL Server Management Studio](/Mis/CreateVirtualPC_SSMS.md) | - **SQL Server Management Studio 2016** i version CTP 3.3
4. [Visual Studio](/Mis/CreateVirtualPC_VS.md) | - **Visual Studio 2015 Update 1**<br/>- **Opdateret til nyeste version** under *Extersions and Update*

