class Reactor10Algo
{
    public static bool reactor_function(string s1, string s2)
    {
        return String.Concat(s1.OrderBy(c => c)) == String.Concat(s2.OrderBy(c => c));
    }
    public static void Exec() { 
        wrd.Reactor_prcl reactor = new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.CITADEL_v2_2B);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}