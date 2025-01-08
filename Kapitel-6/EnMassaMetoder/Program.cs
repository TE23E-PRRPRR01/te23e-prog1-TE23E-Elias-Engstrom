/* **********************************************************************
*                               M A I N
 ********************************************************************** */

Console.Clear();
Console.WriteLine("Hello, World!");

SägHejNamn("Valentin");

TalIKvadrat(5);
TalIKvadrat(7);
TalIKvadrat(1);
TalIKvadrat(8);
TalIKvadrat(9);

/* **********************************************************************
*                             M E T O D E R
 ********************************************************************** */

/// <summary>
/// Skriv ut hälsning
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig! {namn}");

}

/// <summary>
/// Metod som kvadrerar tal
/// </summary>
/// <param name="tal">Nummret</param>
static void TalIKvadrat(double tal)
{
    Console.WriteLine(tal*tal);
}