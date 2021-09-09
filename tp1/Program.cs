using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            transportePublico[] misTransportes = new transportePublico[10];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la cantidad de pasajeros del taxi");
                string inputUser = Console.ReadLine();
                int cant;
                while (!int.TryParse(inputUser, out cant))
                {
                    Console.WriteLine("Debe ingresar un número, intente nuevamente: ");
                    inputUser = Console.ReadLine();
                }
                taxi tax = new taxi(cant);
                misTransportes[i] = tax;
            }

            for (int i = 5; i < 10; i++)
            {
                Console.WriteLine("Ingrese la cantidad de pasajeros del omnibus");
                string inputUser = Console.ReadLine();
                int cant;
                while (!int.TryParse(inputUser, out cant))
                {
                    Console.WriteLine("Debe ingresar un número, intente nuevamente: ");
                    inputUser = Console.ReadLine();
                }
                omnibus omni = new omnibus(cant);
                misTransportes[i] = omni;
            }
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (misTransportes[i] is taxi)
                {
                    Console.WriteLine("Taxi  "+ (i+1) + ":  "  + misTransportes[i].pasajeros + "  pasajeros");
                   
                }
                else
                {
                    Console.WriteLine("Omnibus  "+ (i-4)+":  " + misTransportes[i].pasajeros + "  pasajeros");
                    

                }
                    
                
            }
        Console.ReadLine();

        }

    }
                
            
}
    

