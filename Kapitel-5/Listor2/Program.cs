// Skapa en lista med action-spel
Console.Clear();

List<string> listaActionSpel = [];
List<string> listaÄventyrSpel = [];

while (true)
{
    Console.Clear();
    
    Console.WriteLine("""
Vilken lista vill du lägga till spel i.
1. Action
2. Äventyr
3. Båda
4. Avsluta

""");
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Write("Nu ska du fylla i hur många spel du vill ha i listan: ");
        string Spel = Console.ReadLine();
        int antalSpel = int.Parse(Spel);
        for (var i = 0; i < antalSpel; i++)
        {
            Console.Write("Ange ett action-spel: ");
            string actionSpel = Console.ReadLine();
            listaActionSpel.Add(actionSpel);
        }

        foreach (var actionSpel in listaActionSpel)
        {
            Console.WriteLine($"- {actionSpel}");
        }
    }
    else if (val == "2")
    {
        Console.Write("Nu ska du fylla i hur många spel du vill ha i listan: ");
        string Spel = Console.ReadLine();
        int antalSpel = int.Parse(Spel);
        for (var i = 0; i < antalSpel; i++)
        {
            Console.Write("Ange ett äventyr-spel: ");
            string äventyrSpel = Console.ReadLine();
            listaÄventyrSpel.Add(äventyrSpel);
        }

        foreach (var äventyrSpel in listaÄventyrSpel)
        {
            Console.WriteLine($"- {äventyrSpel}");
        }
    }
    else if (val == "3")
    {
        Console.Write("Nu ska du fylla i hur många action-spel du vill ha i listan: ");
        string Spel = Console.ReadLine();
        int antalSpel = int.Parse(Spel);
        for (var i = 0; i < antalSpel; i++)
        {
            Console.Write("Ange ett action-spel: ");
            string actionSpel = Console.ReadLine();
            listaActionSpel.Add(actionSpel);
        }
        Console.Write("Nu ska du fylla i hur många äventyr-spel du vill ha i listan: ");
        string Spel1 = Console.ReadLine();
        int antalSpel1 = int.Parse(Spel1);
        for (var i = 0; i < antalSpel1; i++)
        {
            Console.Write("Ange ett äventyr-spel: ");
            string äventyrSpel = Console.ReadLine();
            listaÄventyrSpel.Add(äventyrSpel);
        }

        Console.WriteLine("Action spelen:");
        foreach (var actionSpel in listaActionSpel)
        {
            Console.WriteLine($"- {actionSpel}");
        }

        Console.WriteLine("Äventyr spelen:");
        foreach (var äventyrSpel in listaÄventyrSpel)
        {
            Console.WriteLine($"- {äventyrSpel}");
        }


    }
    else if (val == "4")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else 
    {
        Console.WriteLine("Du inmatade ett fel värde!");
    }
}



