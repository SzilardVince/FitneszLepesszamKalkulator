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
string telj = "";
if (atlag >= 10000) telj = "Kiváló forma, teljesítetted a célt!";
else if (atlag >= 7000) telj = "Átlagos aktivitás, jó úton jársz.";
else telj = "Kevés mozgás, több aktivitás szükséges!";