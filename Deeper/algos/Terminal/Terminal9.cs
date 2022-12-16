class Terminal9Algo
{
    public static bool terminal_function(Triplet<int> triplet)
    {
        int sum = 0;
        for (int i = 1; i <= 3; i++) { sum += triplet[i]; }
        if(sum <= 1) 
            return false;
        for(int i = 2; i <= Math.Sqrt(sum); i++)
            if(sum % i == 0) 
                return false;
        return true;
    }
    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.D_702);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}