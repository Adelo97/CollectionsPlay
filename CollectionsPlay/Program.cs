using Seido.Utilities.SeedGenerator;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Collection!");
var _seeder = new csSeedGenerator();
System.Console.WriteLine("Hi");

List<int> ints1 = new List<int>();
for (int i = 0; i < 50; i++)
{
    ints1.Add(_seeder.Next(0, 100));
}
WriteList("Random List", ints1);

static void WriteList(string header, List<int> ints1)
{
    System.Console.WriteLine(header);
    var c = 0;
    foreach (var item in ints1)
    {
        System.Console.WriteLine($"{item,10}");
        if ((c + 1) % 10 == 0)
            System.Console.WriteLine();
        c++;
    }
}

