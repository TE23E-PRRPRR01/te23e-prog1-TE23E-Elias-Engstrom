// Ett dungeon spel med massa rum, saker, fiender och skatter..
Console.Clear();

Console.WriteLine("Ett Dungeon spel ");

// Programvariabler (state variables)
string rum = "hallen";
List<string> inventory = [];

// Spelloop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        Console.Clear();
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser massor av tavlor och en stor matta");
        }
        else if (val == "2")
        {
            rum = "skattkammare";
            Console.WriteLine(".. du går in till skattkaamren ..");
        }

    }
    else if (rum == "skattkammare")
    {
        Console.Clear();
        Console.WriteLine("Du är i skattkammaren");
        Console.WriteLine("Du ser massor av guld och juveler");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Låt det ligga kvar och gå vidare");
        Console.Write("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en nyckel");
            Console.WriteLine("Vill du plocka upp den? j/n");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventory.Add("nyckel");
                Console.WriteLine("Du plockar upp nyckeln lägger den i ditt inventory");
                Console.WriteLine("Du går vidare till köket");
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln");
                Console.WriteLine("Du går vidare till köket");
            }
        }
        else if (val == "2")
        {
            rum = "köket";
            Console.WriteLine("Du låter skatten ligga kvar och går vidare och möter en trollkarl som kastar en eld boll på dig!");
            Console.WriteLine(".. du flyr till köket ..");
        }

    }
    else if (rum == "köket")
    {
        Console.Clear();
        Console.WriteLine("Du är i köket");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Göm dig i skafferiet");
        Console.Write("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en sylvass kniv");
            Console.WriteLine("Vill du plocka upp den? j/n");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventory.Add("kniv");
                Console.WriteLine("Du plockar upp kniven och lägger den i ditt inventory");
            }
            else
            {
                Console.WriteLine("Du lämnar kniven och låter trollkaren kommer närmare och sedan dödar dig med eld bollar");
                break;
            }
        }
        else if (val == "2")
        {
            rum = "skafferiet";
            Console.WriteLine("Du gömmer dig i skafferiet och hittar en hemlig dörr som leder till en annan del av slottet");
        }
    }
    else if (rum == "skafferiet")
    {
        Console.Clear();
        Console.WriteLine("Du är i tronrummet");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Fly ut ur slottet");
        Console.Write("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser ett svärd och trollkaren som kastade eld bollar på dig");
            Console.WriteLine("Vill du döda han? j/n");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventory.Add("kniv");
                Console.WriteLine("Du plockar upp svärdet och lägger den i ditt inventory");
                Console.WriteLine("Du dödar trollkaren och tar hans trollstav");
                inventory.Add("trollstav");
                Console.WriteLine("Du dödar han och flyr från slottet");
            }
            else
            {
                Console.WriteLine("Du lämnar svärdet och trollkaren kommer närmare och sedan dödar dig med eld bollar");
                break;
            }
        }
        else if (val == "2")
        {
            rum = "Utsidan";
            Console.WriteLine("Du lyckas fly ut ur slottet och överlever");
            break;
        }
    }
}
