using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Storev2
{
	 class FileGeneratorService
	{
//Initializating the Data folder 
		public static void GenerateFiles()
		{
      string path = Directory.GetCurrentDirectory() + "\\Data";
			if (!Directory.Exists(path)) 
            {
                     DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("The Data directory was created successfully at {0}.", Directory.GetCreationTime(path));
            }

			string pathString = path+"\\StoreSetings.xml";
			 
			 if (!File.Exists(pathString))
        {
            
         XDocument doc = new XDocument(new XElement("Store"));
         doc.Save(pathString);
			Console.WriteLine("The file StoreSetings was created successfully at {0}.", File.GetCreationTime(pathString));
			 }

			pathString = path+"\\Inventory.xml";
			
			 if (!File.Exists(pathString))
        {
          XDocument doc = new XDocument(new XElement("Inventory"));
          doc.Save(pathString);
			Console.WriteLine("The file Inventory was created successfully at {0}.", File.GetCreationTime(pathString));
			 }
			pathString = path+"\\Employees.xml";
			
			 if (!File.Exists(pathString))
        {
          XDocument doc = new XDocument(new XElement("Employees"));
          doc.Save(pathString);
			Console.WriteLine("The file Employee was created successfully at {0}.", File.GetCreationTime(pathString));
			 }
	}

	}
}
