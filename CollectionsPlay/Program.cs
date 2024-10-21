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

    WriteList("Shuffeld List", ints1);

    //var uniqueInts = new HashSet<ints1>(ints1);
    var uniqueInts = new  SortedSet<int>(ints1);
    WriteList("Unique List", uniqueInts.ToList());

    System.Console.WriteLine($"Duplictates exists: {ints1.Count > uniqueInts.Count}");


    var nrInts = new Dictionary<int, int>();
    foreach  (var item in ints1)
    {
        if (nrInts.ContainsKey(item))
        {
            nrInts[item]++;
        }
        else
        {
            nrInts.Add(item, 1);
        }
    }
        foreach(var item in  nrInts)
        {
            System.Console.WriteLine(item);
        }

    /*
    var dic = new Dictionary<string, List<string>>();
    dic.Add("AC/DE", new List<string>()  {"fly on the Wall", "Tnt", "Back in black", "Rock or Bust"});
    dic.Add("Metallica", new List<string>()  {"Black Album"});
    dic.Add("The Beatles", new List<string>()  {"Abby Road", "Sgnt Papper"});
    

    System.Console.WriteLine(dic.ContainsKey("The Beatles"));

    var albums = dic ["The Beatles"];

    foreach(var item in albums)
    {
        System.Console.WriteLine(item);
    }*/
    

static void WriteList(string header, List<int> ints1)

{
    System.Console.WriteLine($"\nheader");
    var c = 0;
    foreach (var item in ints1)
    {
        System.Console.Write($"{item,10}");
        if ((c + 1) % 10 == 0)
            System.Console.WriteLine();
        c++;
    }

    System.Console.WriteLine($"Nr elements: {ints1.Count}");
}



