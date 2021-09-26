using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class OperationExtensions
    {
        public static bool MenorQueCinco(this int numero)
        {
            return numero < 5;
        }
    }
}
