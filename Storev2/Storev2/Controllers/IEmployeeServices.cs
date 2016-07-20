using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  interface IEmployeeService
  {
    void AddEmployee(IEmployee x, Store y);
    void RemoveEmployee(string num, string ssnmb, Store y);
    void ListEmployees(Store y);
    void FindEmployee(string name, string ssn, Store y);

  }
}
