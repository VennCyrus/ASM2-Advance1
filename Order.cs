using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_Advance
{
    public class Order
    {
        // fields
        private int id;
        private Customer customer;
        private DateTime date;
        private List<OrderDetail> orderDetails = new List<OrderDetail>();

        // get and set methods
        public int Id
        {
            get
            {
                return id;
            }
            set { id = value; }
        }
        public List<OrderDetail> OrderDetailsList
        {
            get
            {
                return orderDetails;
            }
            set
            {
                orderDetails = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }
        // constructors
        public Order(int id, Customer customer, DateTime date)
        {
            Id = id;
            Customer = customer;
            Date = date;
        }

        public Order()
        {

        }



        // add orderDetail
        public void AddOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailsList.Add(orderDetail);
        }

        // show all order details
        public void showOrderDetails()
        {
            Console.WriteLine("Order detail list: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var orderDetail in OrderDetailsList)
            {
                Console.WriteLine($"Username: {orderDetail.Order.Customer.Name}");
                Console.WriteLine($"Product Id: {orderDetail.Product.ProductId}");
                Console.WriteLine($"Quantity {orderDetail.Quantity}");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }

        // to string
        public override string ToString()
        {
            return "Order ID: " + Id + "Client " + customer.Name +
                   "PurchaseDate " + date;
        }
    }
}
