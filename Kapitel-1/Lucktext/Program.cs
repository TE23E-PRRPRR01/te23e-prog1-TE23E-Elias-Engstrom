Console.Clear();

Console.Write("Ange ett Namn: ");
string namn = Console.ReadLine();
Console.Write("Ange ett kroppsdel: ");
string kroppsdel = Console.ReadLine();
Console.Write("Ange en prillasmak: ");
string prillasmak = Console.ReadLine();
Console.Write("Ange ett en siffra: ");
string siffra = Console.ReadLine();
Console.Clear();


if (namn == "" || kroppsdel == "" || prillasmak == "" || siffra == "")
{
    Console.WriteLine("Naj nu blev fel tror jag");
}
else 
{
    Console.WriteLine($"Tjena {namn}, visst är {kroppsdel} smarrig, nästan lika god som {prillasmak}. Du ger den en {siffra}, vad nice!");
}