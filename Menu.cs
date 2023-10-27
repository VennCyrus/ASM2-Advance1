using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_Advance
{

    public class Menu
    {
        // for customer info
        public static string EnterCustomerName()
        {
            Console.WriteLine("Enter customer name: ");
            return Console.ReadLine();
        }

        // for login
        public static void LoginMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Login as Staff");
            Console.WriteLine("2. Login as Customer");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your number: ");
        }

        public static void MenuForStaff()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add product ");
            Console.WriteLine("2. Show all products");
            Console.WriteLine("3. Update product");
            Console.WriteLine("4. Delete product");
            Console.WriteLine("5. Search id of product");
            Console.WriteLine("6. Search name of product");
            Console.WriteLine("7. View all orders");
            Console.WriteLine("8. Logout");
            Console.WriteLine();
            Console.WriteLine("Enter your options here: ");
        }

        public static void MenuForCustomer()
        {
            Console.WriteLine();
            Console.WriteLine("1. Show all products ");
            Console.WriteLine("2. Order a product ");
            Console.WriteLine("3. Logout");
            Console.WriteLine();
            Console.WriteLine("Enter your options here: ");
        }


        // UI for product
        public static int EnterProductId()
        {
            Console.WriteLine("Enter product ID: ");
            return int.Parse(Console.ReadLine());
        }
        public static int EnterProductIdToDelete()
        {
            Console.WriteLine("Enter product ID: ");
            return int.Parse(Console.ReadLine());
        }
        public static double EnterProductPrice()
        {
            Console.WriteLine("Enter price: ");
            return Double.Parse(Console.ReadLine());
        }
        public static string EnterProductName()
        {
            Console.WriteLine("Enter name of product: ");
            return Console.ReadLine();
        }
        public static string EnterProductCategory()
        {
            Console.WriteLine("Enter category of product: ");
            return Console.ReadLine();
        }
        public static int EnterExistProductId()
        {
            Console.WriteLine("Enter the ID of product: ");
            return int.Parse(Console.ReadLine());
        }


        // show error
        public static string DialogIdExisted()
        {
            return "Can not create! Id already exist!, try another!";
        }

        // modify message successfully!
        public static void ModifySuccessfully()
        {
            Console.WriteLine("Modify data successfully!"); ;
        }

        //  bought product successfully
        public static void BoughtSuccessfully()
        {
            Console.WriteLine("Bought product successfully!");
        }

        // modify message fail!
        public static string ModifyFailed()
        {
            return "Modify data failed!";
        }



        // for order product
        public static string EnterName()
        {
            Console.WriteLine("Enter name: ");
            return Console.ReadLine();
        }
        public static int EnterAge()
        {
            Console.WriteLine("Enter age: ");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterAddress()
        {
            Console.WriteLine("Enter address: ");
            return Console.ReadLine();
        }
        public static string EnterPhone()
        {
            Console.WriteLine("Enter phone: ");
            return Console.ReadLine();
        }
        public static int EnterOrderId()
        {
            Console.WriteLine("Enter order Id: ");
            return int.Parse(Console.ReadLine());
        }

        public static int EnterQuantity()
        {
            Console.WriteLine("Enter quantity: ");
            return int.Parse(Console.ReadLine());
        }

    }
}

