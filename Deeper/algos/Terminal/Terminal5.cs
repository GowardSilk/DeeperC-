class Terminal5Algo
{
    public static TripletContainer<int> terminal_function(TripletContainer<int> trCon)
    {
        for(int i = 0; i < trCon.Count - 1; i++) {
            for(int j = i+1; j < trCon.Count; j++)
            {
                if (trCon[j] > trCon[i])
                    (trCon[j], trCon[i]) = (trCon[i], trCon[j]);
            }
        }
        return trCon;
    }
    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.C_303);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}