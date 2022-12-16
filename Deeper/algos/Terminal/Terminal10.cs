class Terminal10Algo
{
    public static TripletContainer<int> terminal_function(TripletContainer<int> trCon)
    {
        TripletContainer<int> new_trCon = new TripletContainer<int>(trCon.Count);
        for(int i = 0; i < trCon.Count; i++)
        {
            if (!new_trCon.Contains(trCon[i]))
                new_trCon.Add(trCon[i]);
        }
        return new_trCon;
    }
    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.D_443);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}