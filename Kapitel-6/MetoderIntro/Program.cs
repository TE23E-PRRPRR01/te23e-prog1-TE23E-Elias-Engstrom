/* **********************************************************************
*                               M A I N
 ********************************************************************** */

Console.Clear();
Console.WriteLine("Hej Metoder!");

// Anropa metoden
//SägHej();

// Anropa metoden meny
//VisaMeny();
SkriverUtEttMeddelande();


/* **********************************************************************
*                             M E T O D E R
 ********************************************************************** */

/// <summary>
/// Metod för att visa en meny
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut uppgifterna
    4. Avsluta
    """);

}

/// <summary>
/// Metod för att skriva ut ett valfritt meddelande
/// </summary>
static void SkriverUtEttMeddelande()
{
    Console.WriteLine("Vad vill du skriva ut i consolen?");
    string meddelande = Console.ReadLine();
    Console.WriteLine(meddelande);
}

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>
static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}
