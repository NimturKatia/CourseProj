using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Ceasar
    {
        public char[] Encr(char[] Data, int shift)
        {
            if (shift > 32)
                shift = shift % 32;
            return Data;
        }
    }
}
