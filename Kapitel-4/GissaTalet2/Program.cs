//Ett program som man ska gissatalet men att man kan gissa flera gånger
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptal mellan dina angivnina parametrar.");

// En variabel för att hålla koll på antal gissningar
int antal = 0;

Console.Write("Minvärde:");
int minvärde = int.Parse(Console.ReadLine());
Console.Write("Maxvärde:");
int maxvärde = int.Parse(Console.ReadLine());

// Slumpar ett tal 1-100
int slumptal = Random.Shared.Next(minvärde, maxvärde + 1);

// Upprepning - loop 
while (true)
{
    // Ställ fråga till användaren
    Console.Write($"Gissa ett tal {minvärde}-{maxvärde}: ");
    int gissning = int.Parse(Console.ReadLine());

    // Räkna upp antal med 1
    antal++;


    // Kontroll om gissning är korrekt?
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat! På {antal} gånger.jMin herre.");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("Nu blev det lite för högt dära.");
    }
    else
    {
        Console.WriteLine("Ajajaja, nu blev det för lågt dära.");
    }



    // Vill användaren gissa vidare
    Console.WriteLine("Vill du gissa vidare? (y/n)");
    if (Console.ReadLine() == "n")
    {
        Console.WriteLine("Okej, hejdå!");
        break;
    }




}

// Slut på spelet 
Console.WriteLine("Tack för idag, du kan dra hem nu!");