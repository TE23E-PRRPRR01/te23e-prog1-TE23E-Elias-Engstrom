// Skapa lista med slumpade tal
// Validera användarens inmatning
Console.Clear();

/* *****************************************
**               Main                     **
***************************************** */


// Deklarera variabler


// Skapa en tom lista för att spara de slumpade talet 
List<int> listaSlumptal = [];

// Fråga igen tills användare mata in ett giltigt
int antal = LäsInHeltal();
Console.WriteLine($"Du vill ha {antal} slumptal!");

// Fråga igen tills användare mata in ett giltigt
int min = LäsInHeltal();
Console.WriteLine($"Lägsta slumptal blir {min}");

// Fråga igen tills användare mata in ett giltigt
int max = LäsInHeltal();
Console.WriteLine($"Högsta slumptal blir {max}");

/* *****************************************
**           Mina egna metoder            **
***************************************** */
static int LäsInHeltal()
{
    int heltal = 0;
    while (true)
{
    // Fråga användaren hur många slumptal som ska skapas
    Console.Write("Ange heltal: ");

    bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
    if (lyckades)
    {
        
        break;
    }
    else
    {
        Console.WriteLine("Du har inmatat fel så hejdå!");
    }

}   
return heltal;
}

for (int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
Console.WriteLine($"Ditt nya slumptal är {slumptal}");
}