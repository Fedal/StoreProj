using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class Mover : IEmployee
  {
    static string _role = "Mover";

    string _name;
    int _salary;

    public Mover(string name, int salary)
    {
      this.Name = name;
      this.Salary = salary;
    }

    public int Salary
    {
      get
      {
        return _salary;
      }
      set
      {
        _salary = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    }

    public string Role
    {
      get
      {
        return _role;
      }
    }
  }
}
