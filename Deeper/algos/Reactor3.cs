using System.Text;

class Reactor3Algo
{
    public static string reactor_function(sString strng_str)
    {
        var ans = new StringBuilder();
        for(int i = 0; i < strng_str.value.Length; i++)
        {
            char x = strng_str.value[i];
            for(int j = 0; j < strng_str.key.Length; j++)
            {
                if(x == strng_str.key[j])
                {
                    ans.Append(strng_str.key[j]);
                    break;
                }
            }
        }
        return ans.ToString();
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor= new wrd.Reactor_prcl();
        reactor.Connect(wrd._REACTOR_.TWINX_B);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}