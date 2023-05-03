using Studteachworkers.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.Input
{
    public class StudentInput
    {
        Students student = new Students();
        Studentlist list = new Studentlist();
        public void StudInput()
        {
            while (true)
            {
                Console.WriteLine("Input your name");
                student.Name = Console.ReadLine();
                Console.WriteLine("Input your surname");
                student.Surname = Console.ReadLine();
                Console.WriteLine("Input your otchestvo");
                student.Otchestvo = Console.ReadLine();
                Console.WriteLine("Input your date of bitrh in format dd/MM/yyyy");
                string? Birthtext = Console.ReadLine();
                student.Birthdate = DateTime.ParseExact(Birthtext, "dd/MM/yyyy", null);
                Console.WriteLine("Input your group");
                student.Group = Console.ReadLine();
                Console.WriteLine("Input by order your subjects and marks before exam. 0 to end filling");
                while (true)
                {
                    string? subject = Console.ReadLine();
                    int mark = Convert.ToInt32(Console.ReadLine());
                    student.progress?.Add((subject, mark));
                    if (Console.ReadLine() == "0")
                    {
                        Console.WriteLine("You ended your input of subjects");
                        break;
                    }
                }
                list.Input();
                Console.WriteLine("Input 0 to end, else something to continue");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            }
        }
    }
}
