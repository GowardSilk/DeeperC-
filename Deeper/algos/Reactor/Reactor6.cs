class Reactor6Algo
{
    public static int reactor_function(string str)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        int final_count = 0;
        foreach(char ch in str)
        {
            if(vowels.Contains(Char.ToLower(ch)))
                final_count++;
        }
        return final_count;
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor= new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.BUCKLAND_EX);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}