
using System;

class Program
{
    static void Main()
    {
        int x, y, z;

        Console.Write("Unesite stranicu x: ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Unesite stranicu y: ");
        y = int.Parse(Console.ReadLine());

        Console.Write("Unesite stranicu z: ");
        z = int.Parse(Console.ReadLine());

        // Provjera jesu li stranice vece od 0
        if (x <= 0 || y <= 0 || z <= 0)
        {
            Console.WriteLine("Stranice moraju biti vece od 0!");
        }
        // Provjera pravokutnog trokuta
        else if (x * x + y * y == z * z ||
                 x * x + z * z == y * y ||
                 y * y + z * z == x * x)
        {
            Console.WriteLine("Zadane vrijednosti su stranice pravokutnog trokuta.");
        }
        else
        {
            Console.WriteLine("Zadane vrijednosti nisu stranice pravokutnog trokuta.");
        }
    }
}
