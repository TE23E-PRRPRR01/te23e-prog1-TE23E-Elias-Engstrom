// Program som räknar ut din BMI utifrån vikt och längd
Console.Clear();

Console.Write("Vad är din vikt i kg?");
double vikt = double.Parse(Console.ReadLine());

Console.Write("Vad är din längd i M?");
double längd = double.Parse(Console.ReadLine());

double bmi = vikt / (längd * längd);
Console.WriteLine($"Du är {bmi} på bmi skalan");



