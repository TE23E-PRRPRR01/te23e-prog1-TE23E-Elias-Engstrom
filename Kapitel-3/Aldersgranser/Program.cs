// Vi ska göra ett litet spel som visar vilka åldrar du får dricka alkohol och vart du får det.
Console.Clear();

Console.WriteLine("Här matar du inte din ålder för att få veta vad du får göra utav dessa påståendena. Gå till kasino, övningsköra, köpa energidryck eller göra värnplikt.");
Console.WriteLine("Ange din ålder.");
int alder = int.Parse(Console.ReadLine());

//Här matar vi in vilka saker man får göra när man är en viss ålder.
if (alder > 20)
{
    Console.WriteLine("Du får gå till kasino t.ex. Cosmopol, övningköra bil, får köpa energidryck och göra värnplikt.");
}
else if (alder >= 16 && alder < 18)
{
    Console.WriteLine("Du får övningsköra, köpa energidryck.");
}
else if (alder == 15)
{
    Console.WriteLine("Då får du köpa energidryck.");
}
else if (alder < 15)
{
    Console.WriteLine("Då får tyvärr inte göra någon av de övanstående påståendena.");
}
else if (alder == 19)
{
    Console.WriteLine("Då får du göra värnplikt, köpa energidryck och övningsköra.");
}