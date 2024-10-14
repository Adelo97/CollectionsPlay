using Seido.Utilities.SeedGenerator;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Collection!");
var _seeder = new csSeedGenerator();
System.Console.WriteLine("Hi Dragon");

List<int> ints1 = new List<int>();
for (int i = 0; i < 50; i++)
{
    ints1.Add(_seeder.Next(0, 100));
}
WriteList("Random List", ints1);
ints1.Sort();
WriteList("Sorted List", ints1);

for  (int i = 0; i < 100; i++)
{
    var idx1  = _seeder.Next(0, ints1.Count);
    var idx2  = _seeder.Next(0, ints1.Count);

    //Swap
    var t  = ints1[idx1];
    ints1[idx1] = ints1[idx2];
    ints1[idx2] = t;

}

System.Console.WriteLine("Shuffeld List");


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

