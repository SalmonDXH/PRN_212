using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Dictionary<int, Product> Products { get; set; }

        public Category()
        {
            Products = new Dictionary<int, Product>();
        }

        // CRUD
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id) == false)
            {
                Products.Add(p.Id, p);
            }
        }

        public void PrintAllProducts()
        {
            foreach(KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p.ToString());
            }
        }

        public Product GetProduct(int id)
        {
            if (Products.ContainsKey(id) == false){
                return null;
            }
            return Products[id];
        }

    }
}
