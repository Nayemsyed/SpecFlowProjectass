using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectass
{
    public class Calculator
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        //public int sub()
        //{
        //    int res;
        //    res = Fnum - Snum;
        //    return res;
        //}
        //public int mul()
        //{
        //    int res;
        //    res = Fnum * Snum;
        //    return res;
        //}
        public int div()
        {
            int res;
            res = Fnum /Snum;
            return res;
        }

    }


}
