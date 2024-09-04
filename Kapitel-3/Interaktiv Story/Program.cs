Console.Clear();
Console.WriteLine("Vill du spela lite granna? (y/n)");

string spela = Console.ReadLine();

if (spela == "y")
{
    Console.WriteLine("Du vaknar upp i en tätskog och ser två vägar, vänster eller höger.");
    Console.WriteLine("Vart går du? (höger/vänster)");
    spela = Console.ReadLine();
    if (spela == "höger")
    {
        Console.WriteLine("Du kommer fram till en liten lägereld där du hittar folk som hjälper dig ut ur skogen. Du vann grattis!");
    }
    else
    {
        Console.WriteLine("Du kommer fram till en grotta när en brun björn ska ut och äta lite mat där du blev middagen. Du förlorade.");
    }
    
}
else
{
    Console.WriteLine("Okej då dra åt helvete!");
}
