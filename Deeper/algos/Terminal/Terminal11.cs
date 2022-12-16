class Terminal11Algo 
{ 
    public static Triplet<int> terminal_function(TripletContainer<int> trCon)
    {
        Dictionary<Triplet<int>, int> dic = new Dictionary<Triplet<int>, int>();
        for(int i = 0; i < trCon.Count; i++)
        {
            if (dic.ContainsKey(trCon.ElementAt(i)))
                dic[trCon.ElementAt(i)]++;
            else
                dic.Add(trCon.ElementAt(i), 0);
        }
        return dic.Keys.Max();
    }
    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.D_230);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}