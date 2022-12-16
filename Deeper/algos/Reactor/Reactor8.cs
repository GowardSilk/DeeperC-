using System.Text;

class Reactor8Algo
{
    public static string reactor_function(string str)
    {
        const string punctiantion = "!()-[]{};:'\"\\,<>./?@#$%^&*_~";
        var new_str = new StringBuilder();
        foreach(char ch in str)
        {
            if(!punctiantion.Contains(ch))
                new_str.Append(ch);
        }
        return new_str.ToString();
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor= new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.PLASIA_v0_2A);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}