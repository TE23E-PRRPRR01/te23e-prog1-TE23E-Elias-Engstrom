// Program som simulerar kända Engineering Flowchart
Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödesschema");

// Visa en ASCii art
Console.WriteLine($"""
        _.---**""**-.       
._   .-'           /|`.     
 \`.'             / |  `.   
  V              (  ;    \  
  L       _.-  -. `'      \ 
 / `-. _.'       \         ;
:            __   ;    _   |
:`-.___.+-*"': `  ;  .' `. |
|`-/     `--*'   /  /  /`.\|
: :              \    :`.| ;
| |   .           ;/ .' ' / 
: :  / `             :__.'  
 \`._.-'       /     |      
  : )         :      ;      
  :----.._    |     /       
 : .-.    `.       /        
  \     `._       /         
  /`-            /          
 :             .'           
  \ )       .-'             
   `-----*"'         
""");
Console.Write("Does it move? (y/n) ");
string answer = Console.ReadLine();

// Kolla om svar är ja eller nej
if (answer == "y")
{ // y = yes
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No problem");
    }
    else
    {
        Console.WriteLine("Please use Duct Tape!");
    }
}
else
{ // n = no
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Please use WD40!");
    }
    else
    {
        Console.WriteLine("No problem!");
    }
}


