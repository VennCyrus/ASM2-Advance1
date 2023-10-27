using System;
using static System.Formats.Asn1.AsnWriter;
using System.Net;

namespace ASM2_Advance
{
    internal class Program
    {
        // for answer at the end of app
        private static char anwser;
        // check isLogin or not
        public static bool isLogin = false;


        // store owner, client, orderDetail
        private static Customer customer = new Customer();
        private static Staff staff = new Staff();

        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------- MIXI MART -----------------------");
            Console.WriteLine();
        MenuCommand:
            do
            {
                try
                {
                    // LOGIN MENU
                    Menu.LoginMenu();
                    int chosenNum = int.Parse(Console.ReadLine());
                    switch (chosenNum)
                    {
                        case 1:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Login as Staff");
                                Console.ForegroundColor = ConsoleColor.White;
                                Menu.MenuForStaff();
                                    do
                                    {
                                        int optionStoreOwner = int.Parse(Console.ReadLine());
                                        int productId;
                                        switch (optionStoreOwner)
                                        {
                                            case 1:
                                                try
                                                {
                                                    productId = Menu.EnterProductId();
                                                    // check if ID for if exist
                                                    while (staff.CheckProductId(productId))
                                                    {
                                                    Menu.DialogIdExisted();
                                                        productId = Menu.EnterProductId();
                                                    }

                                                    // rest of fields
                                                    string productName = Menu.EnterProductName();
                                                    double productPrice = Menu.EnterProductPrice();
                                                    string productCategory = Menu.EnterProductCategory();

                                                    // add to productList as satff
                                                    staff.AddProduct(new Product(productId, productName, productPrice,
                                                        productCategory));

                                                    // add successfully
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Add product successfully!");
                                                    Console.ForegroundColor = ConsoleColor.White;


                                                // repeat menu of store owner
                                                Menu.MenuForStaff();
                                                }
                                                catch (FormatException e)
                                                {
                                                    Console.WriteLine("Please enter right format number: " + e.Message);
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.WriteLine("Error at: " + e.Message);
                                                }

                                                break;
                                            case 2:
                                                foreach (var product in staff.Products)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine(product.ToString());
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                               Menu.MenuForStaff();
                                                break;
                                            case 3:
                                                try
                                                {
                                                    Console.WriteLine("Enter product ID: ");
                                                    int idProductToUpdate = int.Parse(Console.ReadLine());
                                                    while (!staff.CheckProductId(idProductToUpdate))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                    Menu.ModifyFailed();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        staff.UpdateProductById(idProductToUpdate);
                                                    }


                                                    staff.UpdateProductById(idProductToUpdate);

                                                    // enter menu again
                                                    Menu.MenuForStaff();
                                                }
                                                catch (FormatException e)
                                                {
                                                    Console.WriteLine("Please enter right format number: " + e.Message);
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.WriteLine("Error at: " + e.Message);
                                                }

                                                break;
                                            case 4:
                                                try
                                                {
                                                    int idToDelete = Menu.EnterProductIdToDelete();
                                                    while (!staff.CheckProductId(idToDelete))
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                    Menu.ModifyFailed();
                                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                                        idToDelete = Menu.EnterProductId();
                                                    }

                                                    // delete product
                                                    staff.DeleteProduct(idToDelete);

                                                Menu.MenuForStaff();
                                                }
                                                catch (FormatException e)
                                                {
                                                    Console.WriteLine("Please enter right format number: " + e.Message);
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.WriteLine("Error at: " + e.Message);
                                                }

                                                break;
                                            case 5:
                                                int idToUpdate = Menu.EnterExistProductId();
                                                staff.SearchProductById(idToUpdate);
                                            Menu.MenuForStaff();
                                                break;
                                            case 6:
                                                string nameToSearch = Menu.EnterProductName();
                                                staff.SearchProductByName(nameToSearch);
                                            Menu.MenuForStaff();
                                                break;
                                            case 7:
                                                // show order details of user bought
                                                staff.ShowOrderDetails();
                                            Menu.MenuForStaff();
                                                break;
                                            case 8:
                                            Console.WriteLine("You chose to exit!");
                                            goto MenuCommand;
                                                
                                            default:
                                                Console.WriteLine("Invalid number!");
                                                goto MenuCommand;
                                               
                                        }
                                    } while (true);
       
                            } while (chosenNum < 0 && chosenNum > 3);
                        case 2:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Login as Customer");
                                Console.ForegroundColor = ConsoleColor.White;
                                Menu.MenuForCustomer();
                                    do
                                    {
                                        int inputNum = int.Parse(Console.ReadLine());
                                        switch (inputNum)
                                        {
                                            case 1:
                                                staff.ShowProducts();
                                                Menu.MenuForCustomer();
                                                break;
                                                
                                            case 2:
                                                // try - catch
                                                try
                                                {
                                                    int orderId = Menu.EnterOrderId();

                                                    Customer newCustomer = new Customer();
       
                                                    newCustomer.Name = Menu.EnterName();
                                                    newCustomer.Age = Menu.EnterAge();
                                                    newCustomer.Address = Menu.EnterAddress();
                                                    newCustomer.Phone = Menu.EnterPhone();

                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    newCustomer.Display();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    newCustomer.New();
                                                    Console.ForegroundColor = ConsoleColor.White;




                                                DateTime orderDate = DateTime.Now;

                                                Order productOrder = new Order(orderId, newCustomer, orderDate);



                                                // then add to list
                                                customer.AddOrder(productOrder);

                                                    Console.WriteLine("Enter quantity of the product need buy: ");
                                                    int productQuantity = int.Parse(Console.ReadLine());
                                                    for (int i = 0; i < productQuantity; i++)
                                                    {
                                                        Product product = new Product();
                                                        product.ProductId = Menu.EnterProductId();
                                                        while (!staff.CheckProductId(product.ProductId))
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("ID of purchase does not exist!");
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            product.ProductId = Menu.EnterProductId();
                                                        }

                                                        Product productInList =
                                                            staff.searchProductWithObjType(product.ProductId);
                                                        // display product info before buy for user
                                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                                        Console.WriteLine(productInList.ToString());
                                                        Console.ForegroundColor = ConsoleColor.White;

                                                        // Finally add to order detail
                                                        int quantity = Menu.EnterQuantity();

                                                        OrderDetail orderDetail =
                                                            new OrderDetail(productInList,
                                                                productOrder, quantity);

                                                        staff.AddOrderDetail(orderDetail);

                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                    Menu.BoughtSuccessfully();
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                    }
                                                Menu.MenuForCustomer();
                                                }
                                                catch (FormatException e)
                                                {
                                                    Console.WriteLine("Please enter right format number: " + e.Message);
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.WriteLine("Error at: " + e.Message);
                                                }
                                                break;
                                            case 3:
                                            Console.WriteLine("You chose to exit!");
                                            goto MenuCommand;
                                        }
                                    } while (true);

                            } while (chosenNum != 3);

                        case 3:
                            Console.WriteLine("Bye Bye");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option! please try again!");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter right format number: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error at: " + e.Message);
                }

                // verify continue
                Console.WriteLine("Would you like to continue: (Y/N): ");
                anwser = char.Parse(Console.ReadLine());
            } while (anwser == 'Y' || anwser == 'y');
            Console.WriteLine("Bye Bye");
        }

    }
}

