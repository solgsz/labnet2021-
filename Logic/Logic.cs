using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Logic
    {
        float Num1, Num2;
        public Logic(float Num1, float Num2)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
        }
        public float Dividir()
        {
            if (Num2 == 0)
                throw new DivideByZeroException("El número ingresado como divisor es 0");
            else
                return Num1 / Num2;
        }
    }
}
