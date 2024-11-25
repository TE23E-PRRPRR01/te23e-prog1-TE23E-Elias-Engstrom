// En lista av typen List<string> som innehåller några namn
Console.Clear();

List<string> ListaNamn = ["Anna", "Johan", "Filip"];

Console.Write("Ange ett namn som ska läggas till i listan: ");
string namn = Console.ReadLine();

bool korrektinmatning = string.IsNullOrWhiteSpace(namn);
if (korrektinmatning == true)
{
    Console.WriteLine("Försök igen, du har inmatat ett felaktigt meddelande.");
}
else
{
    ListaNamn.Add(namn);
    Console.WriteLine($"Nuvarande lista:  {string.Join(", ", ListaNamn)}");

    Console.Write("Vill du ta bort någon från listan? (j/n) ");
    string val = Console.ReadLine();
    if (val == "j")
    {
        Console.Write("Ange vilket namn som ska bort: ");
        string namnAttTaBort = Console.ReadLine();
        if (ListaNamn.Contains(namnAttTaBort))
        {
            ListaNamn.Remove(namnAttTaBort);
            Console.WriteLine($"Listan efter namnet är borttaget: {string.Join(", ", ListaNamn)}");

            Console.Write("Sök efter ett namn: ");
            string namnSomSöks = Console.ReadLine();
            if (ListaNamn.Contains(namnSomSöks))
            {
                Console.WriteLine($"{namnSomSöks} är i listan");
            }
            else
            {
                Console.WriteLine($"{namnSomSöks} finns inte i listan");
            }

            Console.Write("Vill du sortera listan? (j/n) ");
            string sortera = Console.ReadLine();
            if (sortera == "j")
            {
                ListaNamn.Sort();
                Console.WriteLine($"Listan i alfabetisk ordning: {string.Join(", ", ListaNamn)}");
            }
        }
        else
        {
            Console.WriteLine("Det namnet finns inte listan så försök igen.");
        }
    }
    else
    {
        Console.WriteLine($"Nuvarande lista:  {string.Join(", ", ListaNamn)}");
    }

}

