using Studteachworkers.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.Input
{
    internal class TeacherInput
    {
        Teachers teacher = new Teachers();
        Teacherlist list = new Teacherlist();
        public void Teacherinput()
        {
            while (true)
            {
                Console.WriteLine("Input teacher name");
                teacher.Name = Console.ReadLine();
                Console.WriteLine("Input teacher surname");
                teacher.Surname = Console.ReadLine();
                Console.WriteLine("Input teacher otchestvo");
                teacher.Otchestvo = Console.ReadLine();
                Console.WriteLine("Input teacher date of bitrh in format dd/MM/yyyy");
                string? Birthtext = Console.ReadLine();
                teacher.Birthdate = DateTime.ParseExact(Birthtext, "dd/MM/yyyy", null);
                Console.WriteLine("Input teacher's groups separated by commas");
                teacher.Group = Console.ReadLine();
                Console.WriteLine("Now we will let you maintain the life way for your students. What subjects you are handling? Input 0 to end");
                while(true)
                {
                    string input = Console.ReadLine();
                    if (input == "0")
                    {
                        Console.WriteLine("You ended your input of subjects");
                        break;
                    }
                }
                list.Input();
                Console.WriteLine("If you want to end teacher input, enter 0. Else input something to continue");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            }
        }
    }
}
