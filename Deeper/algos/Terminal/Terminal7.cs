using System.Text;

class Terminal7Algo
{
    public static int terminal_function(Triplet<int> triplet)
    {
        int sum = 0;
        for(int i = 1; i <= 3; i++) { sum += triplet[i]; }
        return Convert.ToInt32(Convert.ToString(sum, 2));
    }
    public static void Exec()
    {
        wrd.Terminal_prcl terminal = new wrd.Terminal_prcl();
        terminal.Connect(wrd._TERMINAL_.C_954);
        terminal.Hijack(terminal_function);
        terminal.Override();
    }
}