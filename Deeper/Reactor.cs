#region WARDEN
using System.Security;
using System.Text;

namespace wrd
{
    public enum _REACTOR_ { 
        R_DISCONNECTED,
        IMPACT_v1_2A,   //A sectors
        IMPACT_v0_9, TWINX_B, COLOSSUS_v0_5,    //B sectors
        MARSCHAL_v014, BUCKLAND_EX, JAMBO_v1_9, PLASIA_v0_2A,   //C sectors
        BEAMX_v093, CITADEL_v2_2B, PYRO_ULT, ERUPT_v0_2, HADES_v0_45    //D sectors
    }
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
        private void Test(string fileName, ref Func<string, int, string> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            string input1 = reader.ReadString();
                            int input2 = reader.ReadInt32();
                            string expected = reader.ReadString();
                            if (f(input1, input2) == expected)
                                this.reactor_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<string, int> f)
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
                            int expected = reader.ReadInt32();
                            if (f(input) == expected)
                                this.reactor_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<string, bool> f)
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
                            bool expected = reader.ReadBoolean();
                            if (f(input) == expected)
                                this.reactor_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<string, string, bool> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            string input1 = reader.ReadString();
                            string input2 = reader.ReadString();
                            bool expected = reader.ReadBoolean();
                            if (f(input1, input2) == expected)
                                this.reactor_hack_success += 0.1f;
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
            if(!isShadowed)
            {
                switch (this.reactor_type)
                {
                    //check if usr is connected
                    case _REACTOR_.R_DISCONNECTED:
                        {   //
                            throw new Exception("Not connected!");
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
                    //
                    case _REACTOR_.PLASIA_v0_2A:
                        {   //
                            Test("Reactor8.dat", ref f);
                            break;
                        }
                    //
                    case _REACTOR_.BEAMX_v093:
                        {   //
                            Test("Reactor9.dat", ref f);
                            break;
                        }
                    //
                    case _REACTOR_.PYRO_ULT:
                        {   //
                            Test("Reactor11.dat", ref f);
                            break;
                        }
                }
            }
        }
        public void Hijack(Func<sString, string> f)
        {
            if(!isShadowed)
            {
                switch (this.reactor_type)
                {
                    case _REACTOR_.R_DISCONNECTED:
                        throw new Exception("Not connected!");
                    case _REACTOR_.TWINX_B:
                        {   //
                            Test("Reactor3.dat", ref f);
                            break;
                        }
                }
            }
        }
        public void Hijack(Func<string, int, string> f)
        {
            if(!isShadowed)
            {
                switch(this.reactor_type)
                {
                    case _REACTOR_.R_DISCONNECTED:
                        throw new Exception("Not connected!");
                    case _REACTOR_.MARSCHAL_v014:
                        Test("Reactor5.dat", ref f);
                        break;
                }
            }
        }
        public void Hijack(Func<string, int> f)
        {
            if(!isShadowed)
            {
                switch (this.reactor_type)
                {
                    case _REACTOR_.R_DISCONNECTED:
                        throw new Exception("Not connected!");
                    case _REACTOR_.BUCKLAND_EX:
                        Test("Reactor6.dat", ref f);
                        break;
                }
            }
        }
        public void Hijack(Func<string, bool> f)
        {
            if(!isShadowed)
            {
                switch (this.reactor_type)
                {
                    case _REACTOR_.R_DISCONNECTED:
                        throw new Exception("Not connected!");
                    case _REACTOR_.JAMBO_v1_9:
                        Test("Reactor7.dat", ref f);
                        break;
                }
            }
        }
        public void Hijack(Func<string, string, bool> f)
        {
            if(!isShadowed)
            {
                switch(this.reactor_type)
                {
                    case _REACTOR_.R_DISCONNECTED:
                        throw new Exception("Not connected!");
                    case _REACTOR_.CITADEL_v2_2B:
                        Test("Reactor10.dat", ref f);
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