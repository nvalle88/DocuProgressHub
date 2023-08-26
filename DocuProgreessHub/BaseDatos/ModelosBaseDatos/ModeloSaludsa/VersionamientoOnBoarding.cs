using System;
using System.Collections.Generic;

namespace  SmartAdmin.Seed.ModelsSaludsa
{
    public partial class VersionamientoOnBoarding
    {
        public int IdVersionamiento { get; set; }
        public int IdOnBoarding { get; set; }

        public OnBoarding IdOnBoardingNavigation { get; set; }
        public Versionamiento IdVersionamientoNavigation { get; set; }
    }
}
