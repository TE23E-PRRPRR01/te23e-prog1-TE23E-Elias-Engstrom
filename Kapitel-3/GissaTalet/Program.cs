﻿// Ett litet spel - gissa ett hemligt heltal
Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt heltal");

//Slumpa ett tal
int slumptalet = Random.Shared.Next(1, 101); // 1-100
Console.WriteLine($"Slumptalet är {slumptalet}");

Console.Write("Gissa ett tal 1-100: ");
// Läs in texten, t.ex. "28"
string gissningText = Console.ReadLine();

// Konvertera texten till ett heltal, blir 100
int gissning = int.Parse(gissningText);

if (gissning == slumptalet)
{
    Console.WriteLine("Bra, du har gissat rätt!");
}
else if (gissning < slumptalet)
{
    Console.WriteLine("Lite för litet tal dära!");
}
else if(gissning > slumptalet)
{
    Console.WriteLine("Ajajaj, nu var det för högt!");
}
