/* *************************************************
 * Namn: Miniräknare i konsolen
 * Beskrivning: Ett program för att utföra matematiska operationer
 * Datum: 2025-01-01
*********************************************** */

/*************************************************
******************* Main *************************
**************************************************/

VisaVälkomsttext();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        Addition();
    }
    else if (val == "2")
    {
        Subtraktion();
    }
    else if (val == "3")
    {
        Multiplikation();
    }
    else if (val == "4")
    {
        Division();
    }
    else if (val == "5")
    {
        Console.WriteLine("👋 Tack för att du använde miniräknaren!");
        break;
    }
    else
    {
        Console.WriteLine("⚠️ Ogiltigt val. Försök igen. ⚠️");
    }
}

/* ************************************************
 * **************** Metoder ***********************
 ************************************************* */

/// <summary>
/// Metod för att visa välkomsttext.
/// </summary>
static void VisaVälkomsttext()
{
    Console.WriteLine("""
    ============================
    Välkommen till miniräknaren!
    ============================
    """);
}

/// <summary>
/// En metod för att visa huvudmenyn.
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""

    🧮 Miniräknare
    1. Addition
    2. Subtraktion
    3. Multiplikation
    4. Division
    5. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
}

/// <summary>
/// En metod för att utföra addition.
/// </summary>
static void Addition()
{
    double tal1 = LäsTal("Ange första talet: ");
    double tal2 = LäsTal("Ange andra talet: ");
    double resultat = tal1 + tal2;
    Console.WriteLine($"Resultatet är: {resultat}");
}

/// <summary>
/// En metod för att utföra subtraktion.
/// </summary>
static void Subtraktion()
{
    double tal1 = LäsTal("Ange första talet: ");
    double tal2 = LäsTal("Ange andra talet: ");
    double resultat = tal1 - tal2;
    Console.WriteLine($"Resultatet är: {resultat}");
}

/// <summary>
/// en metod för att utföra multiplikation.
/// </summary>
static void Multiplikation()
{
    double tal1 = LäsTal("Ange första talet: ");
    double tal2 = LäsTal("Ange andra talet: ");
    double resultat = tal1 * tal2;
    Console.WriteLine($"Resultatet är: {resultat}");
}

/// <summary>
/// En metod för att utföra division.
/// </summary>
static void Division()
{
    double tal1 = LäsTal("Ange första talet: ");
    double tal2 = LäsTal("Ange andra talet: ");
    if (tal2 != 0)
    {
        double resultat = tal1 / tal2;
        Console.WriteLine($"Resultatet är: {resultat}");
    }
    else
    {
        Console.WriteLine("⚠️ Division med noll är inte tillåten.");
    }
}

/// <summary>
/// En metod för att läsa in ett tal från användaren med try-parse.
/// </summary>
static double LäsTal(string meddelande)
{
    double tal;
    while (true)
    {
        Console.Write(meddelande);
        string input = Console.ReadLine();
        if (double.TryParse(input, out tal))
        {
            return tal;
        }
        else
        {
            Console.WriteLine("⚠️ Ogiltig inmatning. Ange ett giltigt tal.");
        }
    }
}
