using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_and_Delegate
{
    public delegate void FindSum(string message);

    class Summa
    {
        public int a;
        public int b;

        public Summa()
        {
            a = 0;
            b = 0;
        }
        public Summa(int a, int b)
        {
            this.a = a;
            this.b = b;            
        }

        
        
        public void Sum(int a, int b, FindSum fs)
        {
            int c = a + b;
            fs(c.ToString());
        }
        
        
    }
}
