using System.Text;

class Terminal5Test
{
    const string fileName = "Terminal5.dat";
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
                    TripletContainer<int> tr_con = new TripletContainer<int>(15);
                    for (int j = 0; j < 15; j++)
                    {
                        //get random Triplet as input
                        Triplet<int> input = new Triplet<int>(rndT.RandomInt(0, 255), rndT.RandomInt(0, 255), rndT.RandomInt(0, 255));
                        //write input
                        writer.Write(input.unit_1);
                        writer.Write(input.unit_2);
                        writer.Write(input.unit_3);
                        tr_con.Add(input);
                    }
                    //get expected from input
                    TripletContainer<int> expected = Terminal5Algo.terminal_function(tr_con);
                    //write it inside the file
                    for(int j = 0; j < expected.Count; j++)
                    {
                        writer.Write(expected[j].unit_1);
                        writer.Write(expected[j].unit_2);
                        writer.Write(expected[j].unit_3);
                    }
                }
            }
        }
    }
}