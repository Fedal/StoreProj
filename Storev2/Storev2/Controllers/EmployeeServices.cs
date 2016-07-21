using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class EmployeeServices : IEmployeeService
  {
    public void AddEmployee(IEmployee x, Store y)
    {
      y.Employees.Add(x);
      FileEmpolyeeControler.AddEmp(x);
    }
    public void RemoveEmployee(string num, string ssnmb, Store y)
    {
      var found = true;
      ;
      foreach (IEmployee x in y.Employees)
      {

        if ((x.Name == num) && (x.SSN == ssnmb))
        {
          Console.WriteLine("The employee {0} was remove.", x.Name);
          y.Employees.Remove(x);
		  FileEmpolyeeControler.RemoveEmp(x.SSN);
          found = false;
          break;
        }
      }
      if (found)
        Console.WriteLine("\nThere are no employees with this credentials!\n");
    }

    public void ListEmployees(Store y)
    {
      {
        Console.WriteLine("               Employees list            ");
        if (y.Employees.Count == 0)
        {
          Console.WriteLine("\nThe store has no empolyees at this moment\n");
        }
        else
        {
          foreach (IEmployee x in y.Employees)
            Console.WriteLine(" Name: {0}, SSN: {1}, Salary: {2}; Role: {3} \n", x.Name, x.SSN, x.Salary, x.Role);
        }
      }
    }

    public void FindEmployee(string num, string ssnmb, Store y)
    {
      var found = false;
      foreach (IEmployee x in y.Employees)
      {

        if ((x.Name == num) && (x.SSN == ssnmb))
        {
          Console.WriteLine("Employee {0} was found:\n{1} , {2}, {3} ,{4}.", x.Name, x.Name, x.SSN, x.Role, x.Salary);
          found = true;
          break;
        }
      }
      if (found == false)
      {
        Console.WriteLine("Employee not found");
      }
    }

  }
}
