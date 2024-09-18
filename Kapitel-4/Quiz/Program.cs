// Ett program som man kan göra en quiz med flera alternativ
Console.Clear();
Console.WriteLine("Idag ska du få testa min quiz");
Console.Write("Vad heter du?: ");
string namn = Console.ReadLine();
Console.WriteLine($"Välkommen {namn}!");

// här har vi de variabler som vi behöver
string svar;
int poäng = 0;
// här börjar frågorna
Console.WriteLine("Vilken färg är himlen?");
Console.WriteLine("A: Blå");
Console.WriteLine("B: Grön");
Console.WriteLine("C: Röd");
svar = Console.ReadLine().ToUpper();
// här visar jag hur man får poäng och vilket som är rätt svar
if (svar == "A") poäng++;
Console.Clear();

Console.WriteLine("Vilket är världens största land?");
Console.WriteLine("A: Sverige");
Console.WriteLine("B: Ryssland");
Console.WriteLine("C: Kina");
svar = Console.ReadLine().ToUpper();
if (svar == "B") poäng++;
Console.Clear();

Console.WriteLine("Vilken är sveriges huvudstad?");
Console.WriteLine("A: Västerår");
Console.WriteLine("B: Borås");
Console.WriteLine("C: Stockholm");
svar = Console.ReadLine().ToUpper();
if (svar == "C") poäng++;
Console.Clear();

Console.WriteLine("Vilken är europas minsta land?");
Console.WriteLine("A: Sverige");
Console.WriteLine("B: Monaco");
Console.WriteLine("C: Vatikanstaten");
svar = Console.ReadLine().ToUpper();
if (svar == "C") poäng++;
Console.Clear();

// Sen avslutar vi med att skriva ut hur mycket poäng man har fått
Console.WriteLine($"{poäng} av 4 rätt!");
Console.WriteLine("Grattis!");