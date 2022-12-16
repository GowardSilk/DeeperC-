﻿using System.Text;

class Terminal12Test
{
    const string fileName = "Terminal12.dat";
    public static void Write()
    {
        using (var stream = File.Open(fileName, FileMode.Create))
        {
            using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
            {
                //create test cases
                RandomTest rndT = new RandomTest();
                for (uint i = 0; i < 10; i++)
                {
                    TripletContainer<int> trCon = new TripletContainer<int>(15);
                    for (int j = 0; j < 15; j++)
                    {
                        //get random Triplet as input
                        Triplet<int> input = new Triplet<int>(rndT.RandomInt(0, 255), rndT.RandomInt(0, 255), rndT.RandomInt(0, 255));
                        //write input
                        writer.Write(input.unit_1);
                        writer.Write(input.unit_2);
                        writer.Write(input.unit_3);
                    }
                    //get expected from input
                    Triplet<int> expected = new Triplet<int>(1, 2, 3);// Terminal12Algo.terminal_function(trCon);
                    //write it inside the file
                    writer.Write(expected.unit_1);
                    writer.Write(expected.unit_2);
                    writer.Write(expected.unit_3);
                }
            }
        }
    }
}