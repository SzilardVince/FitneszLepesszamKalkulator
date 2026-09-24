List<int> szaml = new List<int>();

Console.WriteLine("=== Heti Lépésszám Rögzítése ===");

for(int i=0;i<=4;i++)
{
    Console.Write($"{i+1}.nap lépésszáma: ");
    szaml.Add(int.Parse(Console.ReadLine()));
}
