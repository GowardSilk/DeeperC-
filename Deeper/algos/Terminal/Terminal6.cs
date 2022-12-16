class Terminal6Algo { 
    public static Triplet<int> terminal_function(TripletContainer<int> trCon)
    {
        TripletContainer<int> dupTripletCon = new TripletContainer<int>(trCon.Count);
        foreach(Triplet<int> triplet in trCon)
        {
            if (dupTripletCon.Contains(triplet))
                return triplet;
            else
                dupTripletCon.Add(triplet);
        }
        return dupTripletCon[0];
    }
    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.C_246);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}
