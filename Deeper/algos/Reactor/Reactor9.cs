using System.Text;

class Reactor9Algo
{
    public static string reactor_function(string str)
    {
        var new_str = new StringBuilder();
        foreach (char c in str)
        {
            if(((byte)c) < 48 && ((byte)c) > 57)
                new_str.Append(c);
        }
        return new_str.ToString();
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor= new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.BEAMX_v093);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}
