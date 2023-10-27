using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_Advance
{
    public class Customer : Person
    {
        private int id;
        private List<Order> orders = new List<Order>();

        // get and set method
        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        // constructors
        public Customer(int id)
        {
            Id = id;
        }
        public Customer()
        {

        }
        public Customer(string name, int age,
            string address, string phone, int id)
            : base(name, age, address, phone)
        {
            Id = id;
        }


        // add a order
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        // remove order
        public bool RemoveOrder(Order order)
        {
            var orderInList = Orders.FirstOrDefault(p =>
                p.Id == order.Id);
            if (orderInList == null)
            {
                Console.WriteLine("Order not found!");
                return false;
            }

            Orders.Remove(order);
            return true;
        }
        public override void New()
        {
            Console.WriteLine("New customer!");
        }
        public override void Display()
        {
            Console.WriteLine("\nName:" + Name + "\nAge:" + Age + "\nAddress " + Address + "\nPhone number: " + Phone);
            Console.WriteLine("________________________");
        }

        public override string ToString()
        {
            return "\nName:" + Name + "\nAge:" + Age + "\nAddress " + Address + "\nPhone number: " + Phone;
        }

    }
}
