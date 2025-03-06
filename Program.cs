using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace Employee_Management_System
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                
                Console.WriteLine("Select an action to Perform:");
                Console.WriteLine("1.Display an Employee details");
                Console.WriteLine("2.Display all Employees details");
                Console.WriteLine("3.Add Employee");
                Console.WriteLine("4.Update Employee Details");
                Console.WriteLine("5.Delete an Employee");
                Console.WriteLine("6.Exit");
                Console.WriteLine("-------------------------------------******-------------------------------------------");
                Console.WriteLine("Choose your Action:");
                string choice= Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("\nDisplaying employee Details");
                        Employee.Display_Details(employees);
                        break;
                    case "2":
                        Console.WriteLine("\nDisplaying all employee Details");
                        Employee.DisplayAll(employees);
                        break;
                    case "3":
                        Console.WriteLine("\nAdding Employee");
                        Employee.Add(employees);
                        break;
                    case "4":
                        Console.WriteLine("\nUpdating Employee Details");
                        Employee.Update(employees);
                        break;
                    case "5":
                        Console.WriteLine("\nDeleting Employee");
                        Employee.Delete(employees);
                        break;
                    case "6":
                        Console.WriteLine("\nExiting!!");
                        return;
                    default:
                        Console.WriteLine("\nEnter a valid Input!!");
                        continue;
                }

            }
        }
    }
}
