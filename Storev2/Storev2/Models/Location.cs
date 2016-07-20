using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class Location
	{
		string _name;

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

		int _row;

		public int Row
		{
			get
			{
				return _row;
			}
			set
			{
				_row = value;
			}
		}

		int _shelve;

		public int Shelve
		{
			get
			{
				return _shelve;
			}
			set
			{
				_shelve = value;
			}
		}

		public Location(string name, int row, int shelve)
		{
			Name = name;
			Row = row;
			Shelve = shelve;
		}
	}
}
