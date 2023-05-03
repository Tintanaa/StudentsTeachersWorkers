using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.University
{
    public class Teachers:IPeople
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Otchestvo { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Group { get; set; } 
        public List<string> marks { get; set; }
        public List<(string, string, int)> Studentmarks { get; set; }//student, group, subject, mark
    }
    public class Teacherlist
    {
        Teachers teacher = new Teachers();
        public List<Teachers> teacherlist = new List<Teachers>();
        public void Input()
        {
            teacherlist.Add(new Teachers()
            {
                Name = teacher.Name,
                Surname = teacher.Surname,
                Otchestvo = teacher.Otchestvo,
                Birthdate = teacher.Birthdate,
                Group = teacher.Group,
                Studentmarks = teacher.Studentmarks
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
