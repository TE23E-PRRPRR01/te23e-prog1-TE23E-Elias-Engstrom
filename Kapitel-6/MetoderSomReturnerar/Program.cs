/* **********************************************************************
*                               M A I N
 ********************************************************************** */
// Använd metoder här
Console.Clear();

//Console.WriteLine($"Svaret är {Multiplicera(40, 9.56):F2}");
//Console.WriteLine($"Svaret är {Dividera(12045.19158325, 514.1594):F5}");
//Console.WriteLine($"Texten omvänd är {VändText("Måndag")}");
LäsInHelTal();

/* **********************************************************************
*                             M E T O D E R
 ********************************************************************** */
// Skapa metoder här

/// <summary>
/// Gör matte grejer
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Multiplicera(double tal1, double tal2)
{
    double summa2 = tal1 * tal2;
    return ( summa2);
}

/// <summary>
/// Gör ännu mer matte grejer
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dividera(double tal1, double tal2)
{
    double summa2 = tal1 / tal2;
    return ( summa2);
}


/// <summary>
/// Koverterar en text till texten omvänd
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
static string VändText(string text)
{
    string omvändText = "";
    for (var i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}

/// <summary>
/// Säkert sätt att läsa in ett tal (utan att det krashar)
/// </summary>
static int LäsInHelTal()
{
    int tal = 0;
    string textSomBlirTal = Console.ReadLine();
    if(int.TryParse(textSomBlirTal, out tal))
    {
        return tal;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett giltigt tal. Försök igen!");
        return LäsInHelTal();
    }
    
}