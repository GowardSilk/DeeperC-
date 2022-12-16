using System.Text;

class Reactor11Test
{
    const string fileName = "Reactor11.dat";
    public static void Write()
    {
        using (var stream = File.Open(fileName, FileMode.Create))
        {
            using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
            {
                //create test cases
                RandomTest rndT = new RandomTest();
                const string chars = "abcdefghijklmnopqrstuvwxyz";
                for (uint i = 0; i < 10; i++)
                {
                    //get random string as input
                    string input = rndT.RandomString(10, chars);
                    //write input
                    writer.Write(input);
                    //get expected from input
                    string expected = Reactor11Algo.reactor_function(input);
                    //write it inside the file
                    writer.Write(expected);
                }
            }
        }
    }
}