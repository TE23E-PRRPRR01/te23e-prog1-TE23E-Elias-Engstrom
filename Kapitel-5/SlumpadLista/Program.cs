// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

// Globala variabler
// En lista för heltal
List<int> listaSlumptal = [];

// Be användaren om antal slumpade tal
Console.Write("Hur många tal vill du slumpa?: ");
int antal = int.Parse(Console.ReadLine());

// Be användaren ange min och max värde
Console.Write("Ange min värde: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Ange max värde: ");
int max = int.Parse(Console.ReadLine());

// Loopa 5 ggr
for (int i = 0; i < antal; i++)
{
    // Slumpa ett tal
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    // Lägg till slumptalet i listan
    listaSlumptal.Add(slumptal);

    Console.WriteLine($"Slumptal {i+1}: {slumptal}");
}
