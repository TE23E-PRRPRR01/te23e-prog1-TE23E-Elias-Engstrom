// En liten morsekod app
Console.Clear();
Console.WriteLine("En liten morsekod app");

List<string> alfabet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " ",
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            ".", ",", "!", "?", "(", ")", "'" ];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/",
            "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
            ".-.-.-", "--..--", "-.-.--", "..--..", "-.--.", "-.--.-", ".----." ];

while (true)
{
    Console.WriteLine("""
1. Översätt text till morsekod
2. avsluta
""");
    string val = Console.ReadLine();
    if (val == "2")
    {
        break;
    }
    else
    if (val == "1")
    {
        // Läs in vad användaren vill skriva i morsekod
        Console.Write("Skriv in en text: ");
        string text = Console.ReadLine().ToUpper();

        // Loopa igenom varje tecken i texten för att kunna skriva ut texten i morsekod
        foreach (char tecken in text)
        {
            // Hitta index för tecknet i alfabetet
            int index = alfabet.IndexOf(tecken.ToString());
            if (index >= 0)
            {
                // Skriv ut morsekoden för tecknet med ett mellanslag efter
                Console.Write(morsekod[index] + " ");

                if (tecken == '.')
                {
                    Console.Beep(1000, 200);
                }
                else if (tecken == '-')
                {
                    Console.Beep(1000, 600);
                }
            }
            else
            {
                // Skriv ut tecknet som det är om det inte finns i alfabetet
                Console.WriteLine(tecken);
            }
        }
    }
    else
    {
        Console.WriteLine("Felaktigt val, försök igen");
    }
    Console.WriteLine("\nTryck på valfri tangent för att fortsätta");
    Console.ReadKey();
    Console.Clear();
}