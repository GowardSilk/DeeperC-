using System.Security.Cryptography.X509Certificates;

namespace wrd
{
    public class Shadow_prcl<T1, T2>
    {
        private List<Tuple<T1, T2>> TestCases;
        public Shadow_prcl(List<Tuple<T1, T2>> testCases)
        {
            TestCases = testCases;
        }
        public Shadow_prcl() { }
        private bool Comp<T>(T x, T y)
        {
            return EqualityComparer<T>.Default.Equals(x, y);
        }
        public void Hijack(Func<T2, T1> f)
        {
            int TestSuccess = 0;
            foreach(var Test in TestCases)
            {
                if (Comp(f(Test.Item2), Test.Item1))
                {
                    Console.WriteLine("[SHADOW]: Test failed!");
                    Console.WriteLine("Function arguments: {0}", Test.Item2);
                    Console.WriteLine("Expected function output: {0}", Test.Item1);
                    Console.WriteLine("But received: {0}", f(Test.Item2));
                }
                else
                    TestSuccess++;
            }
            Console.WriteLine("Out of {0} test, {1} passed", this.TestCases.Count, TestSuccess);
        }
        public void Disconnect(ref wrd.Terminal_prcl terminal)
        {
            terminal.isShadowed = true;
        }
        public void Disconnect(ref wrd.Reactor_prcl reactor)
        {
            reactor.isShadowed = true;
        }
    }
}