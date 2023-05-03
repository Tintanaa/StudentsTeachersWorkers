using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.University
{
    public class Managers:IPeople
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Otchestvo { get; set; }
        public DateTime Birthdate { get; set; }
        public List<(int, string, string)> Orders { get; set; }//number of order, order, spreading of order

        
    }
    public class Managerlist
    {
        Managers manager = new Managers();
        public List<Managers> ManagerList = new List<Managers>();
        public void Input()
        {
            ManagerList.Add(new Managers()
            {
                Name = manager.Name,
                Surname = manager.Surname,
                Otchestvo = manager.Otchestvo,
                Birthdate = manager.Birthdate,
                Orders = manager.Orders
            });
        }
        public void WriteToConsole(IEnumerable list)
        {
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
        }
    }
}
