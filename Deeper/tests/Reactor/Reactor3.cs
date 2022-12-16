using System.Diagnostics;
using System.Text;

class Reactor3Test
{
    const string fileName = "Reactor3.dat";
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
                    sString input = new sString {
                        value = rndT.RandomString(10, chars),
                        key = rndT.RandomString(10, chars)
                    };
                    //write input
                    writer.Write(input.value);
                    writer.Write(input.key);
                    //get expected from input
                    string expected = Reactor3Algo.reactor_function(input);
                    //write it inside the file
                    writer.Write(expected);
                }
            }
        }
    }
}