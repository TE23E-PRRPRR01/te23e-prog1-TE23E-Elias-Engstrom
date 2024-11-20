// En for loop som skriver ut alla heltal från 1 till 10
Console.Clear();

/*
Console.Write("Ange ett minvärde: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Ange ett maxvärde: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Jämna siffror: ");
for (int i = min; i <= max; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
}

Console.Write("\nUdda siffror: ");
for (int i = min; i <= max; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i}, ");
    }
}
*/


// Använd en for-loop för att skriva ut ett pyramidmönster med stjärnor (*).
Console.Write("Ange antal rader för julgranen: ");
int rader = int.Parse(Console.ReadLine());

for (int i = 1; i <= rader; i++)
{
    for (int j = i; j < rader; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= (2 * i - 1); k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < rader - 1; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("**");
}