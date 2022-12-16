using System.Text;

class Reactor5Test { 
    const string fileName = "Reactor5.dat";
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
                    string input1 = rndT.RandomString(10, chars);
                    int input2 = rndT.RandomInt(10);
                    //write input
                    writer.Write(input1);
                    writer.Write(input2);
                    //get expected from input
                    string expected = Reactor5Algo.reactor_function(input1, input2);
                    //write it inside the file
                    writer.Write(expected);
                }
            }
        }
    }
}
