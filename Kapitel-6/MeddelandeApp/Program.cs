/******************************
            Main
******************************/
VisaIntro();

// Variabler
string filnamn = "MaDrilla.txt";

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();
    

    if (val =="1")
    {
        SparaMeddelande(filnamn);
    }
    else if (val == "2")
    {
        LäsMeddelande(filnamn);
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Försök igen, du gjorde ett inmatningsfel.");
    }
}



/******************************
             Metoder
******************************/

/// <summary>
/// Visar en presentation för programmet
/// </summary>
static void VisaIntro()
{
    Console.Clear();
    
    Console.WriteLine("""
    ==========================================
    Program för att spara meddelande på disken
    ==========================================
    """);
}

/// <summary>
/// Visar en meny för användaren
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""

    1. Spara Meddelande
    2. Läsa Meddelande
    3. Avsluta programmet
    """);
    Console.Write("Ange ett val: ");
}

/// <summary>
/// En metod som låter användaren spara ned ett meddelande i en txt fil
/// </summary>
static string SparaMeddelande(string filen)
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();
    File.WriteAllText(filen, meddelande);
    Console.WriteLine("Ditt meddelande har sparats!");
    return filen;
}

/// <summary>
/// En metod som läser upp meddelanden
/// </summary>
static void LäsMeddelande(string filen)
{
    string meddelande = File.ReadAllText(filen);
    Console.WriteLine("-----------------------------");
    Console.WriteLine(meddelande);
    Console.WriteLine("-----------------------------");
}


