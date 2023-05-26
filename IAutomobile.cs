using System;
using System.Collections.Generic;
using System.Text;

namespace References_Houston_Morgan
{
    interface IAutomobile
    {

        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringify();

    }
}
