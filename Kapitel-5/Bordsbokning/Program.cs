// Labb Bordsbokning    
Console.Clear();

Console.WriteLine("Detta är Centralrestaurangens bordshanterare");


List<(int antal, string namn)> bordData = new List<(int, string)>
{
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
};

string meny = """
1. Visa alla bord
2. Ändra bordsinformation
3. Markera att ett bord är ledigt
4. Avsluta programmet 
""";

while (true)
{
    Console.WriteLine(meny);
    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine();

    if (val == "1")
    {
        foreach ((int, string) i in bordData)
        {
            if (string.IsNullOrWhiteSpace(i.namn))
            {
                
            }
            Console.WriteLine($"Bord {i} - " );
        }
    }
    else if (val == "2")
    {

    }
    else if (val == "3")
    {

    }
    else if (val == "4")
    {

    }
    else
    {
        Console.WriteLine("Felaktig inmatning, tryck på valfri knapp för att gå vidare");
        Console.ReadKey();
        Console.Clear();
    }
}
