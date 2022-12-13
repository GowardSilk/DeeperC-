class Reactor1Algo {
    public static string reactor_function(string str)
    {
        return str.ToUpper();
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor = new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.IMPACT_v1_2A);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}
