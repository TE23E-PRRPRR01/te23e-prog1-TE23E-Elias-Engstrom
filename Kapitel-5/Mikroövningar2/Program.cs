// En lista med 5 namn
Console.Clear();

List<string> namnLista = ["Elias", "Johnny", "Filip", "Viktor", "Bolin"];
List<string> orterLista = ["Tullinge", "Huddinge", "Järfälla", "Tumba"];
List<int> årtalLista = [1945, 2007, 2016, 2020, 2024];

Console.WriteLine($"Min kompisar är: {string.Join(", ", namnLista)}");
Console.Write("Ett namn som du kollar om redan finns eller lägga till den i listan: ");
string nyttNamn = Console.ReadLine();
if (namnLista.Contains(nyttNamn))
{
    Console.WriteLine($"{nyttNamn} finns redan i listan");
}
else
{
    namnLista.Add(nyttNamn);
    Console.WriteLine(string.Join(", ", namnLista));
}
