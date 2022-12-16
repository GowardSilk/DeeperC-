using System.Text;

class Reactor11Algo
{
    public static string reactor_function(string str)
    {
        //char temp;
        //var ans = new StringBuilder();
        //int sum = 0;
        //for (int i = 0; i < str.Length; i++)
        //{
        //    temp = str[i];
        //    int j;
        //    for (j = 0; j < str.Length; j++)
        //    {
        //        if (str[i] == str[j])
        //        {
        //            sum += 1;
        //        }
        //    }


        //    if (sum == 1) 
        //        ans.Append(str[i]);

        //    else {
        //        ans.Append(str[i]);
        //        ans.Append(sum.ToString());
        //    }

        //    sum = 0;
        //}
        //return str;
        Dictionary<string, int> hash_map = new Dictionary<string, int>();
        string temp;
        int sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            temp = str.Substring(i, 1);
            hash_map.Add(temp, 0);
            for (int j = 0; j < str.Length; j++)
            {
                if (str.Substring(i, 1) == str.Substring(j, 1))
                {
                    if (hash_map.ContainsKey(temp)) { sum += 1; hash_map[temp] = sum; }
                }
            }
            sum = 0;
        }
        var ans = new StringBuilder();
        foreach (KeyValuePair<string, int> entry in hash_map)
        {
            ans.Append(string.Join(String.Empty, entry.Key, entry.Value.ToString()));
        }
        return ans.ToString();
    }
    public static void Exec()
    {
        wrd.Reactor_prcl reactor = new wrd.Reactor_prcl();
        wrd.Shadow_prcl<string, string> shadow = new wrd.Shadow_prcl<string, string>();
        shadow.Append(new List<Tuple<string, string>>
        {
            Tuple.Create("d3c2fgh", "dddccfgh")
        });
        shadow.Hijack(reactor_function);
        reactor.Connect(wrd._REACTOR_.PYRO_ULT);
        reactor.Hijack(reactor_function);
        reactor.Override();
    }
}