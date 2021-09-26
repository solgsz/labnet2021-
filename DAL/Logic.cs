using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;

namespace Logic
{
    public class Logic
    {
        private readonly NorthwingContext context;

        public Logic()
        {
            context = new NorthwingContext();

        }
        public List<Customers> GetCustomers()
        {
            return context.Customers.ToList();
        }
        public List<Products> WhithoutStock()
        {
            return context.Products.Where(p => p.UnitsInStock == 0).ToList();
        }

        public List<Products> WithStock()
        {
            var query = from produ in context.Products
                        where produ.UnitsInStock > 0 && produ.UnitPrice > 3
                        select produ;
            return query.ToList();
        }

        public List<Customers> CustomersWA()
        {
            return context.Customers.Where(c => c.Region == "WA").ToList();

        }

        public Products Producto ()
        {
            var query = from produ in context.Products
                        where produ.ProductID == 789
                        select produ;
            return query.FirstOrDefault();
        }

        public List<string> NameCustomers()
        {
            List<string> Output = new List<string>();
            var query = from cust in context.Customers
                        select new { nombre = cust.CompanyName.ToUpper(), nombre2 = cust.CompanyName.ToLower() };
            foreach (var Custo in query)
            {
                Output.Add(Custo.nombre + " - " + Custo.nombre2);
            }
            return Output;
        }

        public void CustomersOrders()
        {
            DateTime fecha = new DateTime(1997, 1, 1);
            List<string> Output = new List<string>();
            var query = from cust in context.Customers
                        join ord in context.Orders on cust.CustomerID equals ord.CustomerID
                        where cust.Region=="WA" && ord.OrderDate>=fecha
                        select new { cust,ord};
            foreach (var par in query)
            {
                Console.WriteLine(par.cust +" - "+ par.ord);
            }
        }

        public List<Customers> CustomersWA3()
        {
            return context.Customers.Where(c => c.Region == "WA").Take(3).ToList();
        }

        public List<Products> ProductsSorted()
        {
            var query = from produ in context.Products
                        orderby produ.ProductName
                        select produ;
            return query.ToList();
        }

        public List<Products> ProductsByUnits()
        {
            return context.Products.OrderByDescending(p=>p.UnitsInStock).ToList();
        }
        public void ProductCategories()
        {
            var query = from produ in context.Products
                        join cat in context.Categories on produ.CategoryID equals cat.CategoryID
                        group produ.ProductName by cat.CategoryName into cats
                        select new { Categoria = cats.Key, Productos = cats.ToList() };
            foreach (var par in query)
            {
                Console.WriteLine("Categoría: " + par.Categoria);
                Console.WriteLine("Listado de productos: ");
                foreach (string PName in par.Productos)
                    Console.Write(" " + PName);
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }
        public Products FirstProduct()
        {
            try
            {
                return context.Products.First();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void CustomerOrdersCount()
        {
            var query = from cust in context.Customers
                        select new { Cust = cust, Orders = cust.Orders.Count };
            foreach (var par in query)
            {
                Console.WriteLine("Cliente: " + par.Cust);
                Console.WriteLine("Cantidad de ordenes: "+par.Orders);
                Console.WriteLine("-------------");
            }
        }






    }
}