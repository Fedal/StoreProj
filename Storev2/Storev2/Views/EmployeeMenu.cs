using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{

  class EmployeeMenu
  {
    internal static void Show(Store store)
    {
      int choice = 20;
      while (choice != 0)
      {
        Console.WriteLine("\n Employee menu");
        Console.WriteLine("1: Hire new employee");
        Console.WriteLine("2: Fire employee");
        Console.WriteLine("3: View employee list");

        Console.Write("\n Enter here -->");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
          case 1:
            {
              Console.Clear();
              Add(store);
              break;
            }
          case 2:
            {
              Console.Clear();
              Fire(store);
              break;
            }
          case 3:
            {
              Console.Clear();
              Get(store);
              break;
            }
        }
      }
    }
    //case 1
    public static void Add(Store storex)
    {
      Console.WriteLine(" Hire a new Employee");
      Console.Write(" Please enter the employee's Name: ");
      string E_name = Console.ReadLine();
      Console.Write(" Please enter the employee's Social Security Number: ");
      string E_ssn = Console.ReadLine();
      Console.Write(" Please enter the employee's Salary: ");
      int E_salary = int.Parse(Console.ReadLine());

      Console.WriteLine("What role dose the employee have?");
      Console.WriteLine("1 Seller");
      Console.WriteLine("2 Mover");
      Console.WriteLine("3 Administrator");

      EmployeeServices Emp_serv = new EmployeeServices();
      IEmployeeService IEmp_serv = Emp_serv;

      int x = int.Parse(Console.ReadLine());
      switch (x)
      {
        case 1:
          {
            var N_seler = new Seller(E_name, E_ssn, E_salary);
            IEmp_serv.AddEmployee(N_seler, storex);
            break;
          }
        case 2:
          {
            var N_mover = new Mover(E_name, E_ssn, E_salary);
            IEmp_serv.AddEmployee(N_mover, storex);
            break;
          }
        case 3:
          {
            var N_admin = new Administrator(E_name, E_ssn, E_salary);
            IEmp_serv.AddEmployee(N_admin, storex);
            break;
          }
      }



    }
    //case 2
    public static void Fire(Store x)
    {
      Console.Write(" Please enter the employee's Name: ");
      string E_name = Console.ReadLine();
      Console.Write(" Please enter the employee's Social Security Number: ");
      string E_ssn = Console.ReadLine();

      EmployeeServices Emp_serv = new EmployeeServices();

      IEmployeeService IEmp_serv = Emp_serv;
      IEmp_serv.RemoveEmployee(E_name, E_ssn, x);


      //case 3
    }
    public static void Get(Store x)
    {
      EmployeeServices Emp_serv = new EmployeeServices();
      IEmployeeService IEmp_serv = Emp_serv;

      IEmp_serv.ListEmployees(x);
    }

  }
}

