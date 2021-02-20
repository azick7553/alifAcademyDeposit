using alifAcademyDeposit.Models;
using System;
using System.Threading.Tasks;

namespace alifAcademyDeposit
{
    class Program
    {
        static bool isWorking = true;
        static async Task Main(string[] args)
        {
            while (isWorking)
            {
                switch (ShowMainMenu())
                {
                    case "1":
                        {
                           await AccoutnMenuActionsAsync();
                        }break;
                    case "2":
                        {

                        }
                        break;
                    case "3":
                        {

                        }break;
                    case "4": isWorking = false; break;
                    default:
                        break;
                }

            }
        }

        private async static Task AccoutnMenuActionsAsync()
        {
            while (true)
            {
                switch (ShowCustomerMenu())
                {
                    case "1": //Show All Customers
                        {
                           
                        }
                        break;
                    case "2": //Create customer
                        {
                            var customerModel = CreateCustomerModel();
                            var result = await customerModel.CreateCustomerAsync();
                            if (result > 0)
                            {
                                Console.WriteLine("Customer created successfully!!!");
                            }
                            Console.WriteLine("Press any to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        {

                        }
                        break;
                    case "4": return;
                    default:
                        break;
                }

            }
        }

        static string ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine($"{new string('-', 5)}Main menu{new string('-', 5)}");
            Console.Write("1. Customers\n" +
                          "2. Accountes\n" +
                          "3. Transactions\n" +
                          "4. Exit\n" +
                          "Choice:");
            return Console.ReadLine();
        }

        static string ShowCustomerMenu()
        {
            Console.Clear();
            Console.WriteLine($"{new string('-', 5)}Customers menu{new string('-', 5)}");
            Console.Write("1. Show customers\n" +
                              "2. Create customer\n" +
                              "3. Find customer\n" +
                              "4. back\n" +
                              "Choice:");
            return Console.ReadLine();
        }

        static Customer CreateCustomerModel()
        {
            Console.WriteLine("Where * is Required");
            try
            {
                return new Customer
                {
                    FirstName = ConsoleWriteWithResult("FirstName *:"),
                    LastName = ConsoleWriteWithResult("LastName:"),
                    MiddleName = ConsoleWriteWithResult("MiddleName:"),
                    DateOfBirth = DateTime.Parse(ConsoleWriteWithResult("DateOfBirth * yyyy-mm-dd:")),
                    DocumentNumber = ConsoleWriteWithResult("DocumentNumber *:"),
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Creating customer model error - {ex.Message}");
            }
            return null;
        }

        static string ConsoleWriteWithResult(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
    }
}
