// ett program som slumpar två städer utan tio olika
Console.Clear();
Console.WriteLine("Här kommer två slumpade städer: ");

// Skapar en lista med städerna
List<string> städer = ["Stockholm", "Borås", "Göteborg", "Malmö", "Riyad", "Jönköping", "Örnsköldsvik", "Luleå", "Sundsvall", "Motala"];

int antal = 2;
while (antal > 0)
{
    // Slumpar ett index
    int index  = Random.Shared.Next(0, 11);
    
    // Hämtar staden på det slumpade indexet
    string stad = städer[index];

    // Skriver ut städerna som slumpades
    Console.WriteLine($"{stad}");
    antal--;
}
