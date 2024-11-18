// Ett litet program som Loopar ett namn 10 gånger
Console.Clear();
Console.WriteLine("Ett program som loopar ett namn 10 gånger");

// Variablerna
int antalGånger;
string namn;

while (true)
{
    while (true)
    {
        // Matar in namn
        Console.Write("Skriv in ett namn: ");
        namn = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(namn))
        {
            Console.WriteLine("Error, du har inte lagt ett giltigt meddelande!!!!");
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        // Matar in antal gånger som den ska loopa
        Console.Write("Skriv in antal gånger: ");

        if (int.TryParse(Console.ReadLine(), out antalGånger) && antalGånger <= 10 && antalGånger >= 1)
        {
            break;
        }
        else
        {
            // Om man matar in fel så skickar det ett fel meddelande
            Console.WriteLine("Error, du har inte lagt ett giltigt meddelande!!!!");
        }
    }

    // Loopar antal gånger som man ska loopa namnet
    for (int i = 0; i < antalGånger; i++)
    {
        Console.WriteLine($"{i}. {namn}");
    }

    // Beräkna ett tal med dessa mallar
    while (true)
    {
        Console.Write("Ange ett tal att beräkna: ");
        if (int.TryParse(Console.ReadLine(), out int tal))
        {
            Console.WriteLine($"""
        Ange ett tal: {tal}
        Multiplicerat med 2: {tal * 2}
        Dividerat med 2: {tal / 2}
        Adderat med 2: {tal + 2}
        Subtraherat med 2: {tal - 2}
        """);
            break;
        }
        else
        {
            Console.WriteLine("Error, du har inte lagt ett giltigt meddelande!!!!");
        }
    }

    // Frågar om man vill göra fler gånger
    Console.WriteLine("Vill du göra igen? (j/n)");
    if (Console.ReadLine().ToLower().Trim() != "j")
    {
        break;
    }
}






