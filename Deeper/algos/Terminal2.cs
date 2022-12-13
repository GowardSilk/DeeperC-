using wrd;

class Terminal2Algo
{
    public static Triplet<int> terminal_function(Triplet<int> x)
    {
        return new Triplet<int>(x._triplet_unit_3, x._triplet_unit_1, x._triplet_unit_2);
    }
    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.B);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}