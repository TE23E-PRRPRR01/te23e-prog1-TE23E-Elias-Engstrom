/***********************************************
                    Main
***********************************************/
Console.Clear();

string meddelande = AngeMeddelande();

int nycjek = AngeNyckel();

Kryptering(meddelande, nycjek);



/***********************************************
                    Metoder
***********************************************/

/// <summary>
/// En metod som hämtar ett meddelande och returnerar den
/// </summary>
/// <returns></returns>
static string AngeMeddelande()
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();
    return meddelande;
}

/// <summary>
/// En metod som hämtar en krypteringsnyckel och returnerar den
/// </summary>
/// <returns></returns>
static int AngeNyckel()
{
    // Ceasar-kryptering, addera en nyckel (te.x. 2)
    Console.Write("Ange en nyckel: ");
    int nyckel = int.Parse(Console.ReadLine());
    return nyckel;
}

/// <summary>
/// En metod som får meddelande och nyckel från metoder och sedan använder nyckeln för att kryptera meddelandet genom Ceasar kryptering
/// </summary>
/// <param name="meddelande"></param>
/// <param name="nyckel"></param>
static void Kryptering(string meddelande, int nyckel)
{
    string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

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
}