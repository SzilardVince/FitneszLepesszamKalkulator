List<int> szaml = new List<int>();

Console.WriteLine("=== Heti Lépésszám Rögzítése ===");

for(int i=0;i<=4;i++)
{
    Console.Write($"{i+1}.nap lépésszáma: ");
    szaml.Add(int.Parse(Console.ReadLine()));
}
int osz = 0;
for (int i = 0; i <= 4; i++)
{
    osz += szaml[i];
}
double atlag = osz / 5.0;
