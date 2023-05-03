using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.University
{
    public class Students:IPeople
    {
        public string? Name { get; set; }
        public string? Surname { get; set;}
        public string? Otchestvo { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Group { get; set; }
        public List<(string?, int)> progress { get; set; } //Subject, mark.
    }
    public class Studentlist
    {
        Students stud = new Students();
        public List<Students> studentlist = new List<Students>();
        public void Input()
        {
            studentlist.Add(new Students()
            {
                Name = stud.Name,
                Surname = stud.Surname,
                Otchestvo = stud.Otchestvo,
                Birthdate = stud.Birthdate,
                Group = stud.Group,
                progress= stud.progress
            });
        }
        public List<Students> GetList()
        {
            return studentlist;
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
