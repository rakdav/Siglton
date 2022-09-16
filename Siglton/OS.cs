using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siglton
{
    internal class OS
    {
        private static OS instance;
        public string Name { get; set; }
        public OS(string name)
        {
            Name = name;
        }
        public static OS getInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }
}
