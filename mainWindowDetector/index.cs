using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace mainWindowDetector
{
    class index
    {
        static void Main(string[] args)
        {
            try
            {
                for (;;)
                {
                    var motherfucker = Process.GetProcessesByName("badboy-prohibitor");
                    if (motherfucker.Length == 0)
                    {
                        Process.Start("badboy-prohibitor");
                    }
                }
            }
            catch
            {

            }
        }
    }
}
