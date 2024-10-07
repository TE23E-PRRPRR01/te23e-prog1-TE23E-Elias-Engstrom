// Vi ska skapa ett program som räknar ut din nettolön efter skatt
Console.Clear();

Console.WriteLine("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");

Console.Write("Vad heter du? ");
string namn = Console.ReadLine();



// Eftersom att lönen måste vara en viss mängd så måste vi gör en grej som kan kolla om din lön ligger mellan dessa parametrar
while (true)
{
    // Nu ska vi låta användaren skriva in sin lön
    Console.Write("Ange din bruttolön i kronor: ");
    int bruttolön = int.Parse(Console.ReadLine());

    if (bruttolön > 10000 && bruttolön < 145000)
    {
        Console.WriteLine($"Din nettolön blir {bruttolön * 78 / 100} kr. Uträkning baserad på bruttolön {bruttolön} kr och marginalskatt 22%");
    }
    else if (bruttolön >= 145000 && bruttolön < 515000)
    {
        Console.WriteLine($"Din nettolön blir {bruttolön * 67 / 100} kr. Uträkning baserad på bruttolön {bruttolön} kr och marginalskatt 33%");
    }
    else if (bruttolön > 515000 && bruttolön < 1000000)
    {
        Console.WriteLine($"Din nettolön blir {bruttolön * 47 / 100} kr. Uträkning baserad på bruttolön {bruttolön} kr och marginalskatt 53%");
    }
    else if (bruttolön < 10000 || bruttolön > 1000000)
    {
        //Om man anger en lön som inte innefattar våra parametrar så kommer det ett felmedelande
        Console.WriteLine($"{namn}. Din bruttolön måste vara mellan 10000kr och 1000000kr");
    }

    // En check för att se om man vill göra om beräkningen
    Console.WriteLine("Vill du göra en ny beräkning? (j/n): ");
    string görom = Console.ReadLine().ToLower().Trim();
    if (görom == "n")
    {
        break; //Break används för att stoppa programmet
    }
}