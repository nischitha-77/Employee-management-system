using System;
using System.Collections.Generic;

namespace Employee_Management_System
{
    class Employee
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        // Constructor
        public Employee(int id, string name, string department, int salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        // Display Employee details
        public static void Display_Details(List<Employee> employees)
        {
            while (true)
            {
                Console.WriteLine("Enter Employee ID to display:");
                int id=int.Parse(Console.ReadLine());
                Employee emp = employees.Find(e => e.Id == id);

                if (emp!=null)
                {
                    Console.WriteLine($"ID: {emp.Id}\nName: {emp.Name}\nDepartment: {emp.Department}\nSalary: {emp.Salary}");

                }
                else
                {
                    Console.WriteLine("\nEmployee does not exist");
                }
                Console.WriteLine("-------------------------------------******-------------------------------------------");
                Console.WriteLine("\nDo you want to Display details of another Employee:(Y/N)");
                string ch = Console.ReadLine().ToLower();
                if (ch != "y") break;
            }

            
        }

        //Display all Employees
        public static void DisplayAll(List<Employee> employees)
        {
            foreach(var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}\nName: {emp.Name}\nDepartment: {emp.Department}\nSalary: {emp.Salary}");
                Console.WriteLine("-------------------------------------******-------------------------------------------");
            }

        }

        //Adding Employees
        public static void Add(List<Employee> employees)
        {
            while (true)
            {
                Console.WriteLine("Enter Employee details:");
                Console.WriteLine("Enter Employee Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Employee Department:");
                string Department = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                int salary = int.Parse(Console.ReadLine());

                //Employee object
                Employee emp = new Employee(id, name, Department, salary);
                employees.Add(emp);
                Console.WriteLine("-------------------------------------******-------------------------------------------");
                Console.WriteLine("\nDo you want to add another employee:(Y/N)\n");
                string choice = Console.ReadLine().ToLower();
                if (choice != "y")
                {
                    Console.WriteLine("\nExiting\n");
                    Console.WriteLine("-------------------------------------******-------------------------------------------");
                    break;
                }
            }
        }


        // Update Employee Details
        public static void Update(List<Employee> employees)
        {
            while (true) 
            {
                Console.Write("\nEnter employee ID to update: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine(" Invalid input! Please enter a numeric Employee ID.");
                    Console.WriteLine("-------------------------------------******-------------------------------------------");
                    continue;
                }

                Employee emp = employees.Find(e => e.Id == id);

                if (emp == null)
                {
                    Console.WriteLine("Employee not found!");
                    Console.WriteLine("-------------------------------------******-------------------------------------------");
                    continue;
                }

                while (true)

                {

                    
                        Console.WriteLine("\nSelect a field to Update:");
                        Console.WriteLine("1. Employee Name");
                        Console.WriteLine("2. Employee Department");
                        Console.WriteLine("3. Employee Salary");
                        Console.WriteLine("4. Exit");
                        Console.Write("Enter your choice: ");
                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.Write("Enter new Name: ");
                                emp.Name = Console.ReadLine();
                                Console.WriteLine("Name updated successfully!");
                                break;

                            case "2":
                                Console.Write("Enter new Department: ");
                                emp.Department = Console.ReadLine();
                                Console.WriteLine(" Department updated successfully!");
                                break;

                            case "3":
                                Console.Write("Enter new Salary: ");
                                if (int.TryParse(Console.ReadLine(), out int newSalary))
                                {
                                    emp.Salary = newSalary;
                                    Console.WriteLine(" Salary updated successfully!");
                                }
                                else
                                {
                                    Console.WriteLine(" Invalid Salary input!");
                                }
                                break;

                            case "4":
                                Console.WriteLine(" Exited Successfully!");
                                return;

                            default:
                                Console.WriteLine(" Enter a valid input (1-4)!");
                                continue;
                        }
                    Console.WriteLine("-------------------------------------******-------------------------------------------");
                    Console.Write("\nDo you want to update other details of the employee? (Y/N): ");
                        string again = Console.ReadLine().ToLower();
                        if (again != "y") break;
                }
                break;
                
            }
        }

        //Delete Employee
        public static void Delete(List<Employee> employees)
        {
            while (true)
            {
                Console.WriteLine("\nEnter Employee ID to delete:");
                int id=int.Parse(Console.ReadLine());
                Employee emp=employees.Find(x => x.Id==id);

                if (emp != null)
                {
                    Console.WriteLine($"Do you want to delete {id}:{emp.Name}:(Y/N)");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "y")
                    {
                        employees.Remove(emp);
                        Console.WriteLine($"Employee {emp.Name} deleted Successfully");
                        Console.WriteLine("-------------------------------------******-------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Employee does not Exist");
                }
                Console.WriteLine("Do you want to delete another Employee:(Y/N)");
                string ch = Console.ReadLine().ToLower();
                if (ch != "y") break;
            }
        }

    }
}
