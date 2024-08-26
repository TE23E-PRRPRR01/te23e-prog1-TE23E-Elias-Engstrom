// Program för att registrera förnamn och efternamn...
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Program för att registrera förnamn och efternamn...");
Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn: ");
string efternamn = Console.ReadLine();
Console.WriteLine("Hej! " + förnamn + " " + efternamn);

// Är det Sigman som loggar in?
if (efternamn == "Engström")
{
    Console.WriteLine("Vad trevlig att du är här!"); 
}
if (förnamn == "Elias")
{
    Console.WriteLine("Vilket finnt namn!");
}