using System.Text;

class Reactor5Algo
{
    public static string reactor_function(string str, int shift)
    {
        var ans = new StringBuilder();
        if(shift > 26) { shift %= 26; }
        byte[] bytes = Encoding.ASCII.GetBytes(str);
        for(int i = 0; i < str.Length; i++)
        {
            char c;
            if (bytes[i] - shift < 97)
            {
                int j = bytes[i]-96;
                c = (char)(123-j);
            }
            else
            {
                c = (char)(bytes[i]-shift);
            }
            ans.Append(c);
        }
        return ans.ToString();
    }
    public static void Exec()
    {
        //wrd.Reactor_prcl reactor = new wrd.Reactor_prcl();
        //reactor.Connect(wrd._REACTOR_.MARSCHAL_v014);
        //reactor.Hijack(reactor_function);
        //reactor.Override();
        string ans = reactor_function("abcde", 2);
        Console.WriteLine(ans);
    }
}