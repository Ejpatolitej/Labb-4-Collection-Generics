using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb_4_Collection_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { ID = 101, Name = "Jack", Gender = "Male", Salary = 530204 };
            Employee employee2 = new Employee() { ID = 102, Name = "Emma", Gender = "Female", Salary = 1349939.53 };
            Employee employee3 = new Employee() { ID = 103, Name = "Emile", Gender = "Male", Salary = 3299.39 };
            Employee employee4 = new Employee() { ID = 104, Name = "Alice", Gender = "Female", Salary = -13939 };
            Employee employee5 = new Employee() { ID = 105, Name = "Jonathan", Gender = "Unknown", Salary = 2499439 };

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee5);
            employeeStack.Push(employee4);
            employeeStack.Push(employee3);
            employeeStack.Push(employee2);
            employeeStack.Push(employee1);

            int i = employeeStack.Count;

            foreach (var item in employeeStack)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", item.ID, item.Name, item.Gender, item.Salary);
                i--;
                Console.WriteLine("Employees left in stack: " + i);
            }

            Console.WriteLine("_________________________________________");

            for (int j = 0; j < 5; j++)
            {
                Employee EPop = employeeStack.Pop();
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", EPop.ID, EPop.Name, EPop.Gender, EPop.Salary);
                Console.WriteLine("Employees left in stack: " + employeeStack.Count);
            }
            employeeStack.Push(employee5);
            employeeStack.Push(employee4);
            employeeStack.Push(employee3);
            employeeStack.Push(employee2);
            employeeStack.Push(employee1);

            Console.WriteLine("_________________________________________");

            Employee EPeek = employeeStack.Peek();
            Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", EPeek.ID, EPeek.Name, EPeek.Gender, EPeek.Salary);
            Console.WriteLine("Employees left in stack: " + employeeStack.Count);
            Employee EPeek2 = employeeStack.Peek();
            Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", EPeek2.ID, EPeek2.Name, EPeek2.Gender, EPeek2.Salary);
            Console.WriteLine("Employees left in stack: " + employeeStack.Count);

            Console.WriteLine("_________________________________________");


            if (employeeStack.Count >= 3)
            {
                Console.WriteLine("Item number 3 in the stack: ");
                Employee EPop = employeeStack.Pop();
                Employee EPop2 = employeeStack.Pop();
                Employee EPop3 = employeeStack.Pop();
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", EPop3.ID, EPop3.Name, EPop3.Gender, EPop3.Salary);
            }
            else
            {
                Console.WriteLine("Item number 3 is not in the stack.");
            }

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            Console.WriteLine("_________________________________________");

            Employee searchItem = employee2;
            if (employeeList.Contains(searchItem))
            {
                Console.WriteLine("Employee 2 exists in the list");
            }
            else
            {
                Console.WriteLine("Employee 2 does not exist in the list");
            }

            Console.WriteLine("_________________________________________");

            Employee Male = employeeList.Find(x => x.Gender.Contains("Male"));
            Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", Male.ID, Male.Name, Male.Gender, Male.Salary);

            Console.WriteLine();

            List<Employee> MaleEmployees = employeeList.FindAll(x => x.Gender.Contains("Male"));
            foreach (var item in MaleEmployees)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}", item.ID, item.Name, item.Gender, item.Salary);
            }
        }
    }
}
