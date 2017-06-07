using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Loteria
    {
        public event Action L1;
        public event Action L2;
        public event Action L3;

        public void losuj()
        {
            //L1?.Invoke();
            switch (Program.rand.Next(1,3))
            {
                case 1:
                    L1?.Invoke();
                    break;
                case 2:
                    L2?.Invoke();
                    break;
                case 3:
                    L3?.Invoke();
                    break;
            }
            L1 = L2 = L3 = null;
        }
    }
}
