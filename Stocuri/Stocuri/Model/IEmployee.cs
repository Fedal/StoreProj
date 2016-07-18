using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
	interface IEmployee
	{
		int Salary
		{
			get;
			set;
		}
		string Name
		{
			get;
			set;
		}
		string Role
		{
			get;
		}
	}
}
