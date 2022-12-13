using System.Text;

class Terminal1Test
{
    const string fileName = "Terminal1.dat";
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
                    //get random Triplet as input
                    Triplet<int> input = new Triplet<int>(rndT.RandomInt(0, 255), rndT.RandomInt(0, 255), rndT.RandomInt(0, 255));
                    //write input
                    writer.Write(input._triplet_unit_1);
                    writer.Write(input._triplet_unit_2);
                    writer.Write(input._triplet_unit_3);
                    Console.WriteLine(input);
                    //get expected from input
                    Triplet<int> expected = Terminal1Algo.terminal_function(input);
                    Console.WriteLine(expected);
                    //write it inside the file
                    writer.Write(expected._triplet_unit_1);
                    writer.Write(expected._triplet_unit_2);
                    writer.Write(expected._triplet_unit_3);
                }
            }
        }
    }
}