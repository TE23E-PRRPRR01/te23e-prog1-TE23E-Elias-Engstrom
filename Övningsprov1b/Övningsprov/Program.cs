Console.Clear();
Console.WriteLine("Filmregister");

// Lista för att lagra filmer
List<string> listaFilmer = [];

// Be användaren att mata in filmer
Console.Write("Ange antal filmer (3-5): ");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
        break;
    }
    else
    {
        Console.WriteLine("Fel! Försök igen med ett heltal.");
    }
}

// Loop för menyn
while (true)
{
    // Visa en meny 
    Console.WriteLine();
    Console.Write("""
1. Lägg till filmer
2. Lista alla filmer
3. Sök en film
4. Avsluta
Välj ett alternativ: 
""");
    string val = Console.ReadLine();

    // Hantera valet
    if (val == "1")
    {
        // Lägger till filmer i listan
        Console.WriteLine();
        for (var i = 0; i < antal; i++)
        {
            Console.Write($"Ange film {i+1}: ");
            listaFilmer.Add(Console.ReadLine());
            
        }

    }
    else if (val == "2")
    {
        // Visar hela listan
        Console.WriteLine();
        foreach (var filmNamn in listaFilmer)
        {
            Console.WriteLine("Här är filmerna i registret");
            Console.WriteLine($"- {filmNamn}");
        }

    }
    else if (val == "3")
    {
        // Söker på en film i listan
        Console.WriteLine();
        Console.Write("Ange en filme att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();
         foreach (var filmNamn in listaFilmer)
        {
            // kolla om varje film börjar på bokstaven
            if (filmNamn.StartsWith(bokstav))
            {
                Console.WriteLine($"- {filmNamn}");
            }
        }
         
    }
    else if (val == "4")
    {
        // Avslutar programmet
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        // Ett felmeddelande 
        Console.WriteLine("Du har inmatat ett värde som är fel. Försök igen!");
    }
}
