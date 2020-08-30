using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g14boost
{
    static class Utility
    {

        /// <summary>
        /// Indicates if we're running on battery power.
        /// If we are, then disable CPU wasting things like animations, background operations, network, I/O, etc
        /// </summary>
        public static bool IsRunningOnBattery()
        {
            {
                PowerLineStatus pls = System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus;

                //Offline means running on battery
                return (pls == PowerLineStatus.Offline);
            }
        }
    }
}
