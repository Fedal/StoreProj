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
      XElement Employe = new XElement("Employe", new XAttribute("SSN", emp.SSN));

      Employe.Add(new XElement("Name", emp.Name));
      Employe.Add(new XElement("Role", emp.Role));
      Employe.Add(new XElement("Salary", emp.Salary));

      doc.Root.Add(Employe);
      doc.Save(path);
    }
    public static void GetEmps(Store store)
    {
      XDocument doc = XDocument.Load(path);
      var AllEmps = from r in doc.Descendants("Employe")
                    select new
                    {
                      Name = r.Element("Name").Value.ToString(),
                      Role = r.Element("Role").Value.ToString(),
                      Salary = int.Parse(r.Element("Salary").Value),
                      SSN = r.Attribute("SSN").Value.ToString(),
                    };

      foreach (var x in AllEmps)
      {
        switch (x.Role)
        {
          case "Seller":
            {
              var N_seler = new Seller(x.Name, x.SSN, x.Salary);
              store.Employees.Add(N_seler);
              break;
            }
          case "Mover":
            {
              var N_mover = new Mover(x.Name, x.SSN, x.Salary);
              store.Employees.Add(N_mover);
              break;
            }
          case "Administrator":
            {
              var N_admin = new Administrator(x.Name, x.SSN, x.Salary);
              store.Employees.Add(N_admin);
              break;
            }
        }
      }
    }
  }
}