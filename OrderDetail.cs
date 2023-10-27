using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_Advance
{
    public class OrderDetail
    {
        private Product product;
        private Order order;
        private int quanity;

        // get and set methods
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public Order Order
        {
            get { return order; }
            set { order = value; }
        }

        public int Quantity
        {
            get { return quanity; }
            set { quanity = value; }
        }


        // constructors
        public OrderDetail(Product product, Order order, int quantity)
        {
            Product = product;
            Order = order;
            Quantity = quantity;
        }

        public OrderDetail()
        {

        }


        public override string ToString()
        {
            return $"Product ID {Product.ProductId}, Product name {Product.Name} " +
                   $"Price {Product.Price}, Product category {Product.Category}";
        }
    }
}
