class Terminal4Algo
{
    public static int terminal_function(TripletContainer<int> tr_con)
    {
        Func<TripletContainer<int>, int, int> calc_diff = (tr_con, pos)
            => tr_con.SumAt(0, tr_con[pos]) - tr_con.SumAt(0, tr_con[pos + 1]);

        int max_diff = calc_diff(tr_con, 0);
        for (int i = 1; i < tr_con.Count - 1; i++)
        {
            if (max_diff < calc_diff(tr_con, i))
                max_diff = calc_diff(tr_con, i);
        }
        return max_diff;
    }

    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.B_524);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}