using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.University
{
    public class Workers:IPeople
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Otchestvo { get; set; }
        public DateTime Birthdate { get; set; }  
    }
    public class Workerslist
    {
        Workers workers = new Workers();
        public List<Workers> WorkersList = new List<Workers>();
        public void Input()
        {
            WorkersList.Add(new Workers()
            {
                Name = workers.Name,
                Surname = workers.Surname,
                Otchestvo = workers.Otchestvo,
                Birthdate = workers.Birthdate
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
