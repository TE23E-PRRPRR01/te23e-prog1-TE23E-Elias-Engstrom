﻿/* *************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2024-09-01
 *********************************************** */

VisaIntro();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        int tal = LäsInHelTal();

        RitaFyrkant(tal);
    }
    else if (val == "2")
    {
        int tal = LäsInHelTal();

        RitaTriangel(tal);
    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, vg försök igen.");
    }
}

/* **********************************************
 *  Metoder 
 ********************************************** */

/// <summary>
/// Läser in ett heltal
/// </summary>
/// <returns></returns>
static int LäsInHelTal()
{
    Console.Write("Ange ett heltal: ");
    string talString = Console.ReadLine();
    int tal;
    while (!int.TryParse(talString, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        talString = Console.ReadLine();
    }
    return tal;
}

/// <summary>
/// Visar ett intro för användaren
/// </summary>
static void VisaIntro()
{
    Console.Clear();
    Console.WriteLine("""
Program för att rita konsolgrafik
===================================
""");
}

/// <summary>
/// Visar en meny för användaren
/// </summary>
static void VisaMeny()
{
    // Skriva ut menyn
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
}

/// <summary>
/// ritar en fyrkant utifrån LäsInHeltal metoden
/// </summary>
/// <param name="tal"></param>
static void RitaFyrkant(int tal)
{
    // Skriv ut fyrkant
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j < tal; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Ritar ut en triangel utifrån LäsInHeltal metoden
/// </summary>
/// <param name="tal"></param>
static void RitaTriangel(int tal)
{
    // Skriv ut triangeln
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}