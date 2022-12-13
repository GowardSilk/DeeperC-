#region WARDEN
using System.Text;

namespace wrd
{
    public enum _REACTOR_ { R_DISCONNECTED, IMPACT_v1_2A, IMPACT_v0_9, TWINX_B, COLOSSUS_v0_5, MARSCHAL_v014, BUCKLAND_EX }
    #region REACTOR
    public class Reactor_prcl
    {
        #region TEST
        private void Test(string fileName, ref Func<string, string> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            string input = reader.ReadString();
                            string expected = reader.ReadString();
                            if (f(input) == expected)
                            {
                                this.reactor_hack_success += 0.1f;
                            }
                            else
                            {
                                Console.WriteLine(input);
                                Console.WriteLine(expected);
                            }
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<sString, string> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            sString input = new sString{ value = reader.ReadString(), key = reader.ReadString() };
                            string expected = reader.ReadString();
                            if (f(input) == expected)
                            {
                                this.reactor_hack_success += 0.1f;
                            }
                            else
                            {
                                Console.WriteLine(input);
                                Console.WriteLine(expected);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        public void Connect(wrd._REACTOR_ reactor)
        {
            this.reactor_type = reactor;
        }
        public void Override()
        {
            Console.WriteLine(this.reactor_hack_success);
        }
        public void Hijack(Func<string, string> f)
        {
            switch (this.reactor_type)
            {
                //check if usr is connected
                case _REACTOR_.R_DISCONNECTED:
                {   //
                    Console.WriteLine("not connected!");
                    break;
                }
                //
                case _REACTOR_.IMPACT_v1_2A:
                {   //
                        Test("Reactor1.dat", ref f);
                        break;
                }
                //
                case _REACTOR_.IMPACT_v0_9:
                {   //
                        Test("Reactor2.dat", ref f);
                        break;
                }
                //
                case _REACTOR_.COLOSSUS_v0_5:
                {   //
                        Test("Reactor4.dat", ref f);
                    break;
                }
            }
        }
        public void Hijack(Func<sString, string> f)
        {
            switch(this.reactor_type)
            {
                case _REACTOR_.R_DISCONNECTED:
                    break;
                case _REACTOR_.TWINX_B:
                {   //
                        Test("Reactor3.dat", ref f);
                    break;
                }
            }
        }
        //member data
        private wrd._REACTOR_ reactor_type = _REACTOR_.R_DISCONNECTED;
        private float reactor_hack_success = 0f;
        public bool isShadowed = false;
        //!member data
    }
    #endregion //!#region TERMINAL_PRCL
}
#endregion //!#region WARDEN