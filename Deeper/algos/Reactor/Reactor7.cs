class Reactor7Algo
{
    public static bool reactor_function(string str)
    {
        char[] strArr = str.ToCharArray();
        Array.Reverse(strArr);
        return new string(strArr) == str;
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor = new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.JAMBO_v1_9);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}