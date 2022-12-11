#region WARDEN
namespace wrd
{
    enum _REACTOR_ { R_DISCONNECTED, IMPACT_v1_2A, IMPACT_v0_9, TWINX_B, COLOSSUS_v0_5 }
    #region REACTOR
    class Reactor_prcl
    {
        public void Connect(wrd._REACTOR_ reactor)
        {
            this.reactor_type = reactor;
        }
        public void Override()
        {
            Console.WriteLine(this.reactor_hack_success);
        }
        public void Hijack<T>(T f)
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
                        break;
                    }
                //
                case _REACTOR_.IMPACT_v0_9:
                    {   //
                        break;
                    }
                //
                case _REACTOR_.TWINX_B:
                    {   //
                        break;
                    }
                //
                case _REACTOR_.COLOSSUS_v0_5:
                    {   //
                        break;
                    }
            }
        }
        //member data
        private wrd._REACTOR_ reactor_type = _REACTOR_.R_DISCONNECTED;
        private float reactor_hack_success = 0f;
        protected bool isShadowed = false;
        //!member data
    }
    #endregion //!#region TERMINAL_PRCL
}
#endregion //!#region WARDEN