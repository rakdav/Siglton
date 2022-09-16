using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siglton
{
    internal class Singlton
    {
        private static Singlton instance;
        public Singlton()
        {
        }

        public static Singlton getInstance()
        {
            if(instance==null)
                instance = new Singlton();
            return instance;
        }
    }
}
