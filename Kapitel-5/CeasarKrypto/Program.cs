// Ett program för kryptering med hjälp av Ceasar-chiffer.
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering med hjälp av Ceasar-chiffer.");

// En lista över alfabetsbokstäverna.
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange en bokstav
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();
// Ceasar-kryptering, addera en nyckel (te.x. 2)
     Console.Write("Ange en nyckel: ");
     int nyckel = int.Parse(Console.ReadLine());

// Loopa igenom meddelandet bokstav för bokstav
foreach (char bokstav in meddelande)
{
    

    // Hitta bokstavens position i alfabetet (index)
    int index = alfabetet.IndexOf(bokstav);

    // Om bokstaven finns i alfabetet
    if (index != -1)
    {
       
        int nyIndex = index + nyckel;
        //Console.WriteLine($"{index} + {nyckel} = {nyIndex}");

        // Plocka ut bokstaven för nyckeln om den är större än alfabetets längd så loopar den om
        char krypteradBokstav = alfabetet[nyIndex % alfabetet.Length];
        Console.Write(krypteradBokstav);
    }
    else
    {
        Console.Write(bokstav);
    }
   

}
