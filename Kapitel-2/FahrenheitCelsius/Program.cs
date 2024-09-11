// Program för att konvertera från Fahrenheit till Celsius
Console.Clear();
Console.WriteLine("Program för att konvertera från Fahrenheit till Celsius");

// Läsa in temperaturen i Fahrenheit
Console.Write("Ange temperaturen i Fahrenheit: ");
double tempFahrenheit = double.Parse(Console.ReadLine());

// Konvertera Fahren till Celsius
double tempCelsius = tempFahrenheit / 1.8 - 32;

// Skriver ut reslutatet
Console.WriteLine($"{tempFahrenheit} grader i Fahrenheit är {tempCelsius} grader i Celsius");

