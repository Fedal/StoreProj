using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	interface IStoreHouse
	{
		List<Item> Items
		{
			get;
			set;
		}
		Layout Layout
		{
			get;
			set;
		}
		string Name
		{
			get;
			set;
		}
	}
}
