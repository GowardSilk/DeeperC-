using System.Text;

class Terminal8Test
{
    const string fileName = "Terminal8.dat";
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
                    writer.Write(input.unit_1);
                    writer.Write(input.unit_2);
                    writer.Write(input.unit_3);
                    //get expected from input
                    int expected = Terminal8Algo.terminal_function(input);
                    //write it inside the file
                    writer.Write(expected);
                }
            }
        }
    }
}