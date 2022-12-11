//includes
using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
//!includes

List<List<char>> l = new List<List<char>>();
l.Add(new List<char> { 'a', 'b', 'c', 'd' });
l.Add(new List<char> { 'e', 'f', 'g', 'h' });
l.Add(new List<char> { 'i', 'j', 'k', 'l' });
l.Add(new List<char> { 'm', 'n', 'o', 'p' });
l.Add(new List<char> { 'q', 'r', 's', 't' });
l.Add(new List<char> { 'u', 'v', 'w', 'x' });
l.Add(new List<char> { 'x', 'y', 'x', '.' });
string text = "text.";

Console.WriteLine("{");

//for every letter in text
for (int i = 0; i < text.Length; i++)
{
    bool found = false;
    //for every list in l
    for (int j = 0; j < l.Count; j++)
    {
        //for every element of sublist of l
        for (int k = 0; k < l[j].Count; k++)
        {
            if (text[i] == l[j][k])
            {
                Console.WriteLine("   {0}, {1}", j, k);
                found = true;
                break;
            }
        }
        if (found)
        {
            break;
        }
    }
}
Console.WriteLine("}");

class Solution
{
    Triplet<int> T_A(TripletContainer<int> tr_con)
    {
        Triplet<int> tr = tr_con[0];
        tr_con.ForEach(delegate (Triplet<int> it_tr)
        {
            if (it_tr > tr)
                tr = it_tr;
        });
        return tr;
    }
    public static void Image()
    {
        // wrd.Pixel[,] pxl_arr = {{
        //     new wrd.Pixel{new wrd.Pixel(wrd.Color.BLACK)}
        // }};
        //wrd.Image img = new wrd.Image(pxl_arr);
    }
    public static void Main()
    {
        // fileStream fs = new fileStream();
        // const string x = "lol";
        // const string fileName = "lol";
        // fs.Write(fileName, x);
        string file_path = @"file.txt";
        try
        {
            // Creating a new file, or overwrite
            // if the file already exists.
            using (FileStream fs = File.Create(file_path))
            {
                // Adding some info into the file
                byte[] info = new UTF8Encoding(true).GetBytes("GeeksforGeeks");
                fs.Write(info, 0, info.Length);
            }

            // // Reading the file contents
            // using(StreamReader sr = File.OpenText(file_path))
            // {
            //     string s = "";
            //     while ((s = sr.ReadLine()) != null) {
            //         Console.WriteLine(s);
            //     }
            // }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}