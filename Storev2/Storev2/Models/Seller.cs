using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class Seller : IEmployee
  {
    static string _role = "Seller";

    string _name;
    int _salary;
    string _ssn;

    public Seller(string name, string ssnx, int salary)
    {
      this.Name = name;
      this.Salary = salary;
      this.SSN = ssnx;
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
    public string SSN
    {
      get
      {
        return _ssn;
      }
      set
      {
        _ssn = value;
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
