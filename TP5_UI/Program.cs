using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Entities;
using ExtentionMethods;

namespace TP5_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic.Logic logic = new Logic.Logic();
            Console.WriteLine("Ejercicio 1:");
            foreach (Customers cus in logic.GetCustomers())
            {
                Console.WriteLine(cus);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 2:");
            foreach (Products prod in logic.WhithoutStock())
            {
                Console.WriteLine(prod);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 3:");
            foreach (Products prod in logic.WithStock())
            {
                Console.WriteLine(prod);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 4:");
            foreach (Customers cus in logic.CustomersWA())
            {
                Console.WriteLine(cus);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 5:");
            Products p = logic.Producto();
            if (p != null)
                Console.WriteLine("Producto 789: " + p);
            else
                Console.WriteLine("Producto 789 es nulo");
            Console.ReadLine();
            Console.WriteLine("Ejercicio 6:");
            foreach (string s in logic.NameCustomers())
                Console.WriteLine(s);
            Console.ReadLine();
            Console.WriteLine("Ejercicio 7:");
            logic.CustomersOrders();
            Console.ReadLine();
            Console.WriteLine("Ejercicio 8:");
            foreach (Customers cus in logic.CustomersWA3())
            {
                Console.WriteLine(cus);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 9:");
            foreach (Products prod in logic.ProductsSorted())
            {
                Console.WriteLine(prod);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 10:");
            foreach (Products prod in logic.ProductsByUnits())
            {
                Console.WriteLine(prod);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 11:");
            logic.ProductCategories();
            Console.ReadLine();
            Console.WriteLine("Ejercicio 12:");
            Products Prod = logic.FirstProduct();
            if (Prod != null)
                Console.WriteLine("El primer producto es: " + Prod);
            else
                Console.WriteLine("El primer producto es nulo");
            Console.ReadLine();
            Console.WriteLine("Ejercicio 13:");
            logic.CustomerOrdersCount();
            Console.ReadLine();

            int numero = 3;

            string resultado = numero.MenorQueCinco() ? "Menor" : "Mayor";
            Console.WriteLine($"El numero:  {numero}, es { resultado} a cinco.");
            Console.ReadKey();
        }
    }
}
