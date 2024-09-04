Console.Clear();
Console.WriteLine("Welcome to the Dungeon Adventure!");
Console.WriteLine("You find yourself at the entrence of a dark dungeon. ");
Console.WriteLine("Do you want to enter? (yes/no)");

string answer1 = "yes"

if (answer1 == "yes")
{
    Console.WriteLine("You step into the dungeon and see two paths.");
    Console.WriteLine("Do you take the left path or the right path? (left/right)");

    string answer2 = "left"

    if (answer2 == "left")
    {
        Console.WriteLine("You encounter a sleeping dragon.");
        Console.WriteLine("Do you try to sneak past or fight it? (sneak/fight)");

        string answer3 = "sneak"

        if (answer3 == "sneak")
        {
            Console.WriteLine("You succesfully sneak past the dragon and find a treasure chest. You win!");

        }
        else if (answer3 == "fight")
        {
            Console.WriteLine("The dragon wakes up and defeats you. Game Over.");

        }
        else
        {
            Console.WriteLine("Invalid choice. Game Over.");
        }

    }
}
else
{
    
}