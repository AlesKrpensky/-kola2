//1
Console.Write("Zadej první číslo: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Zadej druhé číslo: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Součet: " + (a + b));
Console.WriteLine("Rozdíl: " + (a - b));
Console.WriteLine("Součin: " + (a * b));

if (b != 0)
{
    Console.WriteLine("Podíl: " + (a / b));
    Console.WriteLine("Zbytek: " + (a % b));
}
else
{
    Console.WriteLine("Nelze dělit nulou.");
}
//2

Console.Write("Zadej číslo: ");
int cislo = int.Parse(Console.ReadLine());

if (cislo > 0)
{
    Console.WriteLine("Číslo je kladné");
}
else if (cislo < 0)
{
    Console.WriteLine("Číslo je záporné");
}
else
{
    Console.WriteLine("Číslo je nula");
}

if (cislo % 2 == 0)
{
    Console.WriteLine("Číslo je sudé");
}
else
{
    Console.WriteLine("Číslo je liché");
}

 //3
Console.Write("Zadej N: ");
int n = int.Parse(Console.ReadLine());

int soucet = 0;

// Používám for, protože víme,
// od kterého čísla začínáme a kde končíme.
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
    soucet = soucet + i;
}

Console.WriteLine("Součet: " + soucet);
//4
Console.Write("Kolik čísel chceš v poli: ");
int n = int.Parse(Console.ReadLine());

int[] pole = new int[n];

Random nahoda = new Random();

for (int i = 0; i < n; i++)
{
    pole[i] = nahoda.Next(1, 101);
}

Console.WriteLine("Čísla v poli:");

for (int i = 0; i < n; i++)
{
    Console.Write(pole[i] + " ");
}

int minimum = pole[0];
int maximum = pole[0];
int soucet = 0;

for (int i = 0; i < n; i++)
{
    if (pole[i] < minimum)
    {
        minimum = pole[i];
    }

    if (pole[i] > maximum)
    {
        maximum = pole[i];
    }

    soucet = soucet + pole[i];
}

double prumer = (double)soucet / n;

Console.WriteLine();
Console.WriteLine("Minimum: " + minimum);
Console.WriteLine("Maximum: " + maximum);
Console.WriteLine("Průměr: " + prumer);

//5
static int SoucetCislic(int cislo)
{
    int soucet = 0;

    while (cislo > 0)
    {
        soucet = soucet + cislo % 10;
        cislo = cislo / 10;
    }

    return soucet;
}

Console.Write("Zadej číslo: ");
int cislo = int.Parse(Console.ReadLine());

int vysledek = SoucetCislic(cislo);

Console.WriteLine("Součet číslic je: " + vysledek);