class Terminal3Algo
{
    public static Triplet<int> terminal_function(TripletContainer<int> tr_con)
    {
        Triplet<int> tr = tr_con[0];
        for (int i = 1; i < tr_con.Count; i++)
        {
            if (tr_con[i] > tr)
            {
                tr = tr_con[i];
            }
        }
        return tr;
    }

    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.C);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}