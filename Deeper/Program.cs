//includes
using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using wrd;
//!includes

//List<List<char>> l = new List<List<char>>();
//l.Add(new List<char> { 'a', 'b', 'c', 'd' });
//l.Add(new List<char> { 'e', 'f', 'g', 'h' });
//l.Add(new List<char> { 'i', 'j', 'k', 'l' });
//l.Add(new List<char> { 'm', 'n', 'o', 'p' });
//l.Add(new List<char> { 'q', 'r', 's', 't' });
//l.Add(new List<char> { 'u', 'v', 'w', 'x' });
//l.Add(new List<char> { 'x', 'y', 'x', '.' });
//string text = "text.";

//Console.WriteLine("{");

////for every letter in text
//for (int i = 0; i < text.Length; i++)
//{
//    bool found = false;
//    //for every list in l
//    for (int j = 0; j < l.Count; j++)
//    {
//        //for every element of sublist of l
//        for (int k = 0; k < l[j].Count; k++)
//        {
//            if (text[i] == l[j][k])
//            {
//                Console.WriteLine("   {0}, {1}", j, k);
//                found = true;
//                break;
//            }
//        }
//        if (found)
//        {
//            break;
//        }
//    }
//}
//Console.WriteLine("}");

class Solution
{
    public static void Image()
    {
        wrd.Pixel[,] pxl_arr = {
            {
                new wrd.Pixel(wrd.Color.BLACK), 
                new wrd.Pixel(wrd.Color.WHITE),
            }
        };
        wrd.Image img = new wrd.Image(pxl_arr);
    }
    public static void Main()
    {
        Console.WriteLine("Reactor1Algo: ");
        Reactor1Test.Write();
        Reactor1Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor2Algo: ");
        Reactor2Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor3Algo: ");
        Reactor3Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor4Algo: ");
        Reactor4Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor5Algo: ");
        Reactor5Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor6Algo: ");
        Reactor6Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor7Algo: ");
        Reactor7Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor8Algo: ");
        Reactor8Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor9Algo: ");
        Reactor9Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Reactor10Algo: ");
        Reactor10Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal1Algo: ");
        Terminal1Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal2Algo: ");
        Terminal2Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal3Algo: ");
        Terminal3Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal4Algo: ");
        Terminal4Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal5Algo: ");
        Terminal5Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal6Algo: ");
        Terminal6Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal7Algo: ");
        Terminal7Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal8Algo: ");
        Terminal8Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal9Algo: ");
        Terminal9Algo.Exec();
        Console.WriteLine("---------------");
        Console.WriteLine("Terminal10Algo: ");
        Terminal10Algo.Exec();
        Console.WriteLine("---------------");
        //Image2Algo.Exec(); //NOT WORKING
    }
}