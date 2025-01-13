/* **********************************************************************
*                               M A I N
 ********************************************************************** */
Console.Clear();

// Matar celsius för att få ut fahrenheit
TemperaturOmvandlare(20);



/* **********************************************************************
*                             M E T O D E R
 ********************************************************************** */

/*
/// <summary>
/// Skriver ett meddelande vertikalt
/// </summary>
/// <param name="meddelande"></param>
static void SkrivVertikalt(string meddelande)
{
    // Skriv ut ett meddelande vertikalt
    for (var i = 0; i < meddelande.Length; i++) // 0 -> 6
    {
        Console.WriteLine(meddelande[i]);
    }
}

/// <summary>
/// Ritar en fyrkant utfrån en värde som användern väljer
/// </summary>
/// <param name="sidlängd"></param>
static void RitaFyrkant(int sidlängd)
{
    for (var i = 0; i < sidlängd; i++)
    {
        for (var j = 0; j < sidlängd; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void UpprepaText(string text, int antal)
{
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}
*/

/// <summary>
/// gör om celsius till fahrenheit
/// </summary>
/// <param name="celsius"></param>
static void TemperaturOmvandlare(int celsius)
{
    Console.WriteLine($"{celsius} i fahrenheit är {celsius * 9/5 + 32}");
}