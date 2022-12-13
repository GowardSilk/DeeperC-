﻿using wrd;

class Terminal1Algo
{
    public static Triplet<int> terminal_function(Triplet<int> x)
    {
        return new Triplet<int>(x._triplet_unit_3, x._triplet_unit_2, x._triplet_unit_1);
    }
    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.A_220);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}