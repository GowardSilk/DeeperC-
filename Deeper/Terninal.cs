#region WARDEN
using System.Text;

namespace wrd
{
    public enum _TERMINAL_ { T_DISCONNECTED, A_220, B, C, D }
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
                            {
                                this.terminal_hack_success += 0.1f;
                            }
                            else
                            {
                                Console.WriteLine("Input: {0}", input);
                                Console.WriteLine("Expected: {0}", expected);
                            }
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
                            for (uint j = 0; j < 5; j++)
                            {
                                input.Add(new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32()));
                            }
                            Triplet<int> expected = new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
                            if (f(input) == expected)
                            {
                                this.terminal_hack_success += 0.1f;
                            }
                            else
                            {
                                Console.WriteLine("Input: {0}", input);
                                Console.WriteLine("Expected: {0}", expected);
                            }
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
                            for (uint j = 0; j < 5; j++)
                            {
                                input.Add(new Triplet<int>(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32()));
                            }
                            int expected = reader.ReadInt32();
                            if (f(input) == expected)
                            {
                                this.terminal_hack_success += 0.1f;
                            }
                            else
                            {
                                Console.WriteLine("Input: {0}", input);
                                Console.WriteLine("Expected: {0}", expected);
                            }
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
        public void Hijack(Func<Triplet<int>, Triplet<int>> f)
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
                case _TERMINAL_.B:
                    {   //
                        Test("Terminal2.dat", ref f);
                        break;
                    }
            }
        }
        public void Hijack(Func<TripletContainer<int>, Triplet<int>> f)
        {
            switch (this.terminal_type)
            {
                case _TERMINAL_.T_DISCONNECTED:
                    break;
                case _TERMINAL_.C:
                    Test("Terminal3.dat", ref f);
                    break;
            }
        }
        public void Hijack(Func<TripletContainer<int>, int> f)
        {
            switch(this.terminal_type)
            {
                case _TERMINAL_.T_DISCONNECTED:
                    break;
                case _TERMINAL_.D:
                    Test("Terminal4.dat", ref f);
                    break;
            }
        }
        //member data
        private wrd._TERMINAL_ terminal_type = _TERMINAL_.T_DISCONNECTED;
        private float terminal_hack_success = 0f;
        public bool isShadowed = false;
        //!member data
    }
    #endregion //!#region TERMINAL_PRCL
}
#endregion //!#region WARDEN