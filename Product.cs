using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_Advance
{
    public class Product
    {
        // fields
        private int productId;
        private string name;
        private double price;
        private string category;
        // get and set
        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
            }
        }
        // constructor
        public Product(int productId, string name, double price, string category)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Category = category;
        }
        public Product()
        {

        }

        public override string ToString()
        {
            return "Product ID: " + ProductId + " Product name: " +
                   name + " Price: " + price + " Category: " + category;
        }
    }
}
