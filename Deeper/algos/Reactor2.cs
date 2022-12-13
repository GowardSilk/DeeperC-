using System.Text;

class Reactor2Algo
{
    public static string reactor_function(string str) {
        var ans = new StringBuilder();
        for(int i =  0; i < str.Length; i++)
        {
            if (Char.IsUpper(str, i))
            {
                ans.Append(Char.ToLower(str[i]));
            }
            else
            {
                ans.Append(Char.ToUpper(str[i]));
            }
        }
        return ans.ToString();
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor = new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.IMPACT_v0_9);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}