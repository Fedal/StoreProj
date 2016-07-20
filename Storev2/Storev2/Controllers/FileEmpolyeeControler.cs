using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;


namespace Storev2
{
  class FileEmpolyeeControler
  {
    static string path = Directory.GetCurrentDirectory() + "\\Data\\Employees.xml";
    public static void AddEmp(IEmployee emp)
    {
      XDocument doc = XDocument.Load(path);
      XElement Employe = new XElement("Employe",new XAttribute("SSN", emp.SSN));

      Employe.Add (new XElement ("Name", emp.Name));
      Employe.Add (new XElement ("Role", emp.Role));
      Employe.Add (new XElement ("Salary", emp.Salary));

      doc.Root.Add(Employe);
      doc.Save(path);
    }
  }
}
