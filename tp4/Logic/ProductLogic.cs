using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductLogic
    {
        private readonly Model1 context;

        public ProductLogic()
        {
            context = new Model1();
        }
        public List<Categories> GetCategories()
        {
            return context.Categories.ToList();
        }
        public bool AddCategory(Categories C)
        {
            try
            {
                //context.Categories.Add(C);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteCategory(Categories C)
        {
            try
            {
                context.Categories.Remove(C);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateCategory(Categories C)
            {
            try
                {
                    Categories Old = context.Categories.Find(C.CategoryID);
                    Old.CategoryName = C.CategoryName;
                    Old.Description = C.Description;
                    context.SaveChanges();
                    return true;
                }
            catch (Exception)
                {
                    return false;
                }
           
        }
        public List<Shippers> GetShippers()
        {
            return context.Shippers.ToList();
        }
        public bool AddShippers(Shippers S)
        {
            try
            {
                context.Shippers.Add(S);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
        public bool DeleteShippers(Shippers S)
        {
            try
            {
                context.Shippers.Remove(S);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateShippers(Shippers S)
        {
            try
            {
                Shippers Old = context.Shippers.Find(S.ShipperID);
                Old.CompanyName = S.CompanyName;
                Old.Phone = S.Phone;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}