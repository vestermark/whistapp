#Opret database
For at komme i gang, så skal vi have et sted hvor vi kan opbevarer data. Til dette formål skal vi bruge en database i Azure. I forbindelse med oprettelse af denne, så definerer vi også en SQL Server som den skal kører på. Vi definerer ligeledes en *Resource Group* der i Azure er et koncept, som vi kan organiserer resourcer under. Vi kan benytte dette til afregning og oprydning. Hvis vi sletter en resource group, så sletter vi alle dens resourcer (Effektivt - men pas på at du ikke kommer til at slette noget som ikke skulle have været fjernet...).

##Udførlig vejledning:

1)  Login på http://portal.azure.com
_ _ _
2)  Opret en ny database, vælg **``New``** - **``Data + Storage``** - **``SQL Database``**

![](/Images/NewDatabase1.PNG)
_ _ _
3)  Giv databasen navnet **Whistregnskab** og placer den på en ny SQL Server med et nyt navn. 
- Giv SQl Serveren følgende navn **uwpkursus?**, hvor du skriver dine initialer i stedet for **?**
- Vi anbefaler at du benytter en user og password som du nemt kan huske. F.eks **SQLAdmin** og **P@ssw0rdSQL**

![](/Images/NewDatabase2.PNG)
_ _ _

4)  Vælg ny **``Pricing tier``** og **``Basic``**. Hvis du ikke kan se **Basic**, så skal du vælge **``View All``** øverst til højre.

![](/Images/NewDatabase3.PNG)
_ _ _

5)  Under **``Collation``** indsættes "**Danish_Norwegian_CI_AI**"

![](/Images/NewDatabase4.PNG)
_ _ _

6)  Opret en ny Resource Group: **``Resource Group``** - **``Create new Resource Group``** - indsæt navnet: **WhistregnskabRG**

![](/Images/NewDatabase5.PNG)

_ _ _

7)  Vælg **``Create``** for at oprette Databasen og SQL Serveren.


