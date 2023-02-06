  using System;
using System.Collections.Generic;
using System.Text;

namespace References_Hamilton_Dakota
{
    /// <summary>
    /// IAutomobile Interface
    /// </summary>
    interface IAutomobile
    {

        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringify();

    }
}
