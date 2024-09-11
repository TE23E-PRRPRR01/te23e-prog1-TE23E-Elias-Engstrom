// Program för att se kostnaderna av bil hyrning
Console.Clear();
Console.WriteLine("Bil hyrning");

Console.WriteLine("Hur många mil har du åkt?");
double mil = double.Parse(Console.ReadLine());

Console.WriteLine("Hur många dagar har du hyrt?");
double dagar = double.Parse(Console.ReadLine());

double startavgift = 500;

double pris = startavgift + (mil*5) + (dagar*100);

Console.WriteLine($"Priset kommer att vara {pris}kr");
