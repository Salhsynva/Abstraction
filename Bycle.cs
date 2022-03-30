using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Bycle : Vehicle
    {
        public override void Drive(double drivekm)
        {
            Millage += drivekm;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
