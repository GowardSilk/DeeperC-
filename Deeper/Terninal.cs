#region WARDEN
using System.Text;

namespace wrd
{
    public enum _TERMINAL_ { 
        T_DISCONNECTED,
        A_220,
        B_236, B_301, B_524,
        C_303, C_246, C_954, C_282,
        D_702, D_443, D_230, D_990, D_102
    }
    #region TERMINAL_PRCL
    public class Terminal_prcl
    {
        #region TEST
        private void Test(string fileName, ref Func<Triplet<int>, Triplet<int>> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            Triplet<int> input = new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
                            Triplet<int> expected = new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
                            if (f(input) == expected)
                                this.terminal_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<TripletContainer<int>, Triplet<int>> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            TripletContainer<int> input = new TripletContainer<int>(15);
                            for (uint j = 0; j < 15; j++)
                                input.Add(new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32()));

                            Triplet<int> expected = new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());

                            if (f(input) == expected)
                                this.terminal_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<TripletContainer<int>, int> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            TripletContainer<int> input = new TripletContainer<int>(15);
                            for (uint j = 0; j < 15; j++)
                                input.Add(new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32()));

                            int expected = reader.ReadInt32();
                            if (f(input) == expected)
                                this.terminal_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<TripletContainer<int>, TripletContainer<int>> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            TripletContainer<int> input = new TripletContainer<int>(15);
                            for (uint j = 0; j < 15; j++)
                                input.Add(new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32()));

                            TripletContainer<int> expected = new TripletContainer<int>(15);
                            for (uint j = 0; j < 15; j++)
                                input.Add(new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32()));

                            if (f(input) == expected)
                                this.terminal_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<Triplet<int>, int> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            Triplet<int> input = new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());

                            int expected = reader.ReadInt32();

                            if (f(input) == expected)
                                this.terminal_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        private void Test(string fileName, ref Func<Triplet<int>, bool> f)
        {
            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        for (uint i = 0; i < 10; i++)
                        {
                            Triplet<int> input = new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());

                            bool expected = reader.ReadBoolean();

                            if (f(input) == expected)
                                this.terminal_hack_success += 0.1f;
                        }
                    }
                }
            }
        }
        #endregion //!TEST
        public void Connect(wrd._TERMINAL_ terminal)
        {
            this.terminal_type = terminal;
        }
        public void Override()
        {
            Console.WriteLine(this.terminal_hack_success);
        }
        #region HIJACK
        public void Hijack(Func<Triplet<int>, Triplet<int>> f)
        {
            if(!isShadowed)
            {
                switch (this.terminal_type)
                {
                    //check if usr is connected
                    case _TERMINAL_.T_DISCONNECTED:
                        {   //
                            Console.WriteLine("not connected!");
                            break;
                        }
                    //
                    case _TERMINAL_.A_220:
                        {   //
                            Test("Terminal1.dat", ref f);
                            break;
                        }
                    //
                    case _TERMINAL_.B_236:
                        {   //
                            Test("Terminal2.dat", ref f);
                            break;
                        }
                }
            }
        }
        public void Hijack(Func<TripletContainer<int>, Triplet<int>> f)
        {
            if(!isShadowed)
            {
                switch (this.terminal_type)
                {
                    case _TERMINAL_.T_DISCONNECTED:
                        break;
                    case _TERMINAL_.B_301:
                        Test("Terminal3.dat", ref f);
                        break;
                    case _TERMINAL_.C_246:
                        Test("Terminal6.dat", ref f);
                        break;
                    case _TERMINAL_.D_230:
                        Test("Terminal11.dat", ref f);
                        break;
                }
            }
        }
        public void Hijack(Func<TripletContainer<int>, int> f)
        {
            if(!isShadowed)
            {
                switch (this.terminal_type)
                {
                    case _TERMINAL_.T_DISCONNECTED:
                        break;
                    case _TERMINAL_.B_524:
                        Test("Terminal4.dat", ref f);
                        break;
                }
            }
        }
        public void Hijack(Func<TripletContainer<int>, TripletContainer<int>> f)
        {
            if(!isShadowed)
            {
                switch (this.terminal_type)
                {
                    case _TERMINAL_.T_DISCONNECTED:
                        break;
                    case _TERMINAL_.C_303:
                        Test("Terminal5.dat", ref f);
                        break;
                    case _TERMINAL_.D_443:
                        Test("Terminal10.dat", ref f);
                        break;
                }
            }
        }
        public void Hijack(Func<Triplet<int>, int> f)
        {
            if(!isShadowed)
            {
                switch (this.terminal_type)
                {
                    case _TERMINAL_.T_DISCONNECTED:
                        break;
                    case _TERMINAL_.C_954:
                        Test("Terminal7.dat", ref f);
                        break;
                    case _TERMINAL_.C_282:
                        Test("Terminal8.dat", ref f);
                        break;
                }
            }
        }
        public void Hijack(Func<Triplet<int>, bool> f)
        {
            if(!isShadowed)
            {
                switch(this.terminal_type)
                {
                    case _TERMINAL_.T_DISCONNECTED:
                        break;
                    case _TERMINAL_.D_702:
                        Test("Terminal9.dat", ref f);
                        break;
                }
            }
        }
        #endregion //!HIJACK
        //member data
        private wrd._TERMINAL_ terminal_type = _TERMINAL_.T_DISCONNECTED;
        private float terminal_hack_success = 0f;
        public bool isShadowed = false;
        //!member data
    }
    #endregion //!#region TERMINAL_PRCL
}
#endregion //!#region WARDEN