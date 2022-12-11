#region WARDEN
namespace wrd
{
    enum _TERMINAL_ { T_DISCONNECTED, A_220, B, C, D }
    #region TERMINAL_PRCL
    class Terminal_prcl
    {
        public void Connect(wrd._TERMINAL_ terminal)
        {
            this.terminal_type = terminal;
        }
        public void Override()
        {
            Console.WriteLine(this.terminal_hack_success);
        }
        public void Hijack<T>(T f)
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
                        break;
                    }
                //
                case _TERMINAL_.B:
                    {   //
                        break;
                    }
                //
                case _TERMINAL_.C:
                    {   //
                        break;
                    }
                //
                case _TERMINAL_.D:
                    {   //
                        break;
                    }
            }
        }
        //member data
        private wrd._TERMINAL_ terminal_type = _TERMINAL_.T_DISCONNECTED;
        private float terminal_hack_success = 0f;
        protected bool isShadowed = false;
        //!member data
    }
    #endregion //!#region TERMINAL_PRCL
}
#endregion //!#region WARDEN