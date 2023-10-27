using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_Advance
{
    public class Staff
    {
        // fields
        private int id;
        private List<Product> products = new List<Product>();
        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        // get and set methods
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public List<OrderDetail> OrderDetails
        {
            get { return orderDetails; }
            set { orderDetails = value; }
        }

        // constructors
        public Staff(int id)
        {
            Id = id;
        }
        public Staff()
        {

        }

        // add product to list
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // show all product
        public void ShowProducts()
        {
            Console.WriteLine("List of products: ");
            foreach (var product in Products)
            {
                Console.WriteLine($"Id of product: {product.ProductId}");
                Console.WriteLine($"Name of product: {product.Name}");
                Console.WriteLine($"Price of product: {product.Price}");
                Console.WriteLine($"Category of product: {product.Category}");
                Console.WriteLine("-------------------------------------");
            }
        }

        // check product ID
        public bool CheckProductId(int id)
        {
            var productId = Products.FirstOrDefault(p => p.ProductId == id);
            if (productId == null)
            {
                return false;
            }

            return true;
        }

        // search product by ID
        public void SearchProductById(int id)
        {
            var products = from p in
                    Products
                           where p.ProductId == id
                           select p;

            if (products == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not found");
                Console.ForegroundColor = ConsoleColor.White;
            }

            foreach (var product in products)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Id of product: {product.ProductId}");
                Console.WriteLine($"Name of product: {product.Name}");
                Console.WriteLine($"Price of product: {product.Price}");
                Console.WriteLine($"Category of product: {product.Category}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

        // search product by name
        public void SearchProductByName(string name)
        {
            var products = from p in
                    Products
                           where p.Name.Trim().ToLower() == name.Trim().ToLower()
                           select p;

            foreach (var product in products)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Id of product: {product.ProductId}");
                Console.WriteLine($"Name of product: {product.Name}");
                Console.WriteLine($"Price of product: {product.Price}");
                Console.WriteLine($"Category of product: {product.Category}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // update product by ID
        public void UpdateProductById(int id)
        {
            var isExistID = Products.FirstOrDefault
                (p => p.ProductId == id);


            if (isExistID == null)
            {
                Console.WriteLine("Not found!");
            }
            else
            {
                Console.WriteLine("Enter product name: ");
                products.FirstOrDefault(p => p.ProductId
                                             == id)!.Name = Console.ReadLine();
                Console.WriteLine("Enter product price: ");
                products.FirstOrDefault(p => p.ProductId
                                             == id)!.Price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter product category: ");
                products.FirstOrDefault(p => p.ProductId
                                             == id)!.Category = Console.ReadLine();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Update successfully!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // delete product
        public void DeleteProduct(int id)
        {
            var isExistID = products.FirstOrDefault(p => p.ProductId == id);
            if (isExistID == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not Found");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                products.Remove(products.First(p => p.ProductId == id));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Delete product successfully!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // search product object
        public Product searchProductWithObjType(int idProductToSearch)
        {
            var productInList = Products.FirstOrDefault(p =>
                p.ProductId == idProductToSearch);
            if (productInList == null)
            {
                Console.WriteLine("Not found!");
            }

            return productInList;
        }



        // add orderDetail
        public void AddOrderDetail(OrderDetail orderDetail)
        {
            OrderDetails.Add(orderDetail);
        }

        // show all order detail
        public void ShowOrderDetails()
        {
            Console.WriteLine("Order detail list: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var orderDetail in OrderDetails)
            {
                Console.WriteLine($"Username: {orderDetail.Order.Customer.Name}");
                Console.WriteLine($"Product Id: {orderDetail.Product.ProductId}");
                Console.WriteLine($"Quantity {orderDetail.Quantity}");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
