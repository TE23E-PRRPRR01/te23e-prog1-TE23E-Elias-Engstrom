// Använda listor för skapa/hantera samlingar
Console.Clear();

// Lista på trevliga frukter t.ex. "äpple", "apelsin", "mango"
List<string> frukter = ["äpple", "banan", "päron"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Ändra i listan:
frukter[0] = "apelsin";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Gå igenom listan = loopa igenom = från första till sista i listan
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// Skapa en lista på valfri sak (4st)
List<string> spellista = ["GTA V", "Counter-Strike 2", "Roblox", "Uncharted"];
foreach (var spel in spellista)
{
    Console.Write($"{spel}, ");
}
for (int i = 0; i < spellista.Count; i++)
{
    Console.Write($"{spellista[i]}");
}

Console.Clear();

// Skapa ett register
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("\nAnge ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    // Skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }

    
}