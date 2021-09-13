using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Logic
    {
        
        public static float Dividir(float Num1, float Num2)
        {
            if (Num2 == 0)
                throw new DivideByZeroException("ERROR: El número ingresado como divisor es 0");
            else
                return Num1 / Num2;
        }
        public static bool ValidarVocal(string ingreso)
        {
            char vocal;
            if (!char.TryParse(ingreso, out vocal))
            {
                throw new MyException("El valor ingresado no es un caracter");
            }
            if (vocal != 'a' && vocal != 'A' && vocal != 'E' && vocal != 'I' && vocal != 'O' && vocal != 'U' && vocal != 'e' && vocal != 'i' && vocal != 'o' && vocal != 'u') 
                throw new MyException("El usuario no ingresó una vocal");
            else
                return true;
        }
    }
}
