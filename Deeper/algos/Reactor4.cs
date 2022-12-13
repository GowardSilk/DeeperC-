using System.Text;

class Reactor4Algo
{
    public static readonly char[] ARR = {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
        'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
        'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
        'y', 'z'
    };
    public static string reactor_function(string str)
    {
        var ans = new StringBuilder();
        for(int i = 0; i < str.Length; i++)
        {
            for(int j = 0; j < 26; j++)
            {
                if (str[i] == ARR[j])
                {
                    ans.Append(j.ToString());
                }
            }
        }
        return ans.ToString();
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor= new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.COLOSSUS_v0_5);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}