//includes
using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
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
        //Console.WriteLine("Reactor1Algo: ");
        //Reactor1Algo.Exec();
        //Console.WriteLine("---------------");
        //Console.WriteLine("Reactor2Algo: ");
        //Reactor2Algo.Exec();
        //Console.WriteLine("---------------");
        //Console.WriteLine("Reactor3Algo: ");
        //Reactor2Algo.Exec();
        //Console.WriteLine("---------------");
        //Console.WriteLine("Reactor4Algo: ");
        //Reactor2Algo.Exec();
        //Console.WriteLine("---------------");
        //Console.WriteLine("Terminal1Algo: ");
        //Terminal1Algo.Exec();
        //Console.WriteLine("---------------");
        //Console.WriteLine("Terminal2Algo: ");
        //Terminal2Algo.Exec();
        //Console.WriteLine("---------------");
        //Console.WriteLine("Terminal3Algo: ");
        //Terminal2Algo.Exec();
        //Console.WriteLine("---------------");
        //Console.WriteLine("Terminal4Algo: ");
        //Terminal2Algo.Exec();
        //Console.WriteLine("---------------");

        //Image1Algo.Exec(); NOT WORKING
        Reactor5Algo.Exec();
    }
}