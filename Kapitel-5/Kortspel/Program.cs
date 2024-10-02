// Hur man skapar listor och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpar kort ur en kortlek!");

// Skapa en lista som innehåller alla kort
//List<string> kortlek = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"];
//List<string> kortlek = ["🂱", "🂲", "🂳", "🂴", "🂵", "🂶", "🂷", "🂸", "🂹", "🂺", "🂻", "🂽", "🂾"];
List<string> kortlek = ["😃", "🂲", "🂳", "🂴", "🂵", "🂶", "🂷", "🂸", "🂹", "🂺", "🂻", "🂽", "🂾"];

// Ett annat exempel. Lista på 3 årtal
// List<int> årtal = [1914, 1945, 2000];

int antal = 5;
while (antal > 0)
{
// Slumpa index 0-12
int index = Random.Shared.Next(0, kortlek.Count);
//Console.WriteLine($"Det slumpade indexet är {index}");

// Plocka ut det sjunde kortet, index 6
string kort = kortlek[index];

// Ta bort kortet ur kortleken
kortlek.RemoveAt(index);

// Skriv ut det slumpade kortet
Console.WriteLine($"Det slumpade kortet är {kort}");
antal --;
}