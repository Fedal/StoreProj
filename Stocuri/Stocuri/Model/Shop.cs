using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
	class Shop : IStoreHouse
	{
		string _name = "Shop";

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

		List<Item> _items = new List<Item>();

		public List<Item> Items
		{
			get
			{
				return _items;
			}
			set
			{
				_items = value;
			}
		}

		Layout _layout;

		public Layout Layout
		{
			get
			{
				return _layout;
			}
			set
			{
				_layout = value;
			}
		}
	}
}
