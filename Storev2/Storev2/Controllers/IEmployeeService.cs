using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	interface IEmployeeService
	{
		public void AddEmployee(Store somestore);
		public void RemoveEmployee(IEmployee employee);
		public void ListEmployees();
		public void FindEmployee( string name);

	}
}
