using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class Employ
  {

    internal static void Hire(Store store)
    {
      Console.WriteLine();
      string name;
      int salary = 0;
      string role;
      IEmployee employee;

      Console.Write("Employee name: ");
      name = Console.ReadLine();
      Console.Write("Employee salary: ");
      try
      {
        salary = Int32.Parse(Console.ReadLine());
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      Console.Write("Employee role: ");
      role = Console.ReadLine();
      role = role.ToUpper();

      switch (role)
      {
        case "ADMINISTRATOR":
          {
            employee = new Administrator(name, salary);
            store.Employees.Add(employee);
            break;
          }
        case "SELLER":
          {
            employee = new Seller(name, salary);
            store.Employees.Add(employee);
            break;
          }
        case "MOVER":
          {
            employee = new Mover(name, salary);
            store.Employees.Add(employee);
            break;
          }
        default:
          {
            Console.WriteLine("We don't have that role");
            break;
          }
      }
    }

    internal static void ViewEmployees(Store store)
    {
      for (int i = 0; i < store.Employees.Count; i++)
      {
        Console.WriteLine("\t1. Name: {0}", store.Employees[i].Name);
        Console.WriteLine("\t2. Salary: {0}", store.Employees[i].Salary);
        Console.WriteLine("\t3. Role: {0}", store.Employees[i].Role);
        Console.WriteLine();
      }
    }
  }
}
