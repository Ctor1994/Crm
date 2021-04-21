using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Generator
    {
        Random rnd = new Random();

        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();

        public List<Customer> GetNewCustomer(int count)
        {
            var res = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = Customers.Count,
                    Name = GetRandomText()
                };
                Customers.Add(customer);
                res.Add(customer);
            }
            return res;
        }
        private static string GetRandomText()
        {
                return Guid.NewGuid().ToString().Substring(0, 5);
        }
        public List<Seller> GetNewSeller(int count)
        {
            var res = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerId = Sellers.Count,
                    Name = GetRandomText()
                };
                Sellers.Add(seller);
                res.Add(seller);
            }
            return res;
        }
        public List<Product> GetNewProduct(int count)
        {
            var res = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductId = Products.Count,
                    Name = GetRandomText(),
                    Count = rnd.Next(10, 1000),
                    Price = Convert.ToDecimal(rnd.Next(5, 100000) + rnd.NextDouble())
                };
                Products.Add(product);
                res.Add(product);
            }
            return res;
        }

        public List<Product> GetRandomProduct(int min, int max)
        {
            var result = new List<Product>();
            var count = rnd.Next(min, max);

            for (int i = 0; i < count; i++)
            {
                result.Add(Products[rnd.Next(Products.Count + 1)]);
            }
            return result;
        }
    }
}