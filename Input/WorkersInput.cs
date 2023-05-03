using Studteachworkers.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.Input
{
    internal class WorkersInput
    {
        Workers workers = new Workers();
        Studentlist list = new Studentlist();
        public void WorkerInput()
        {
            while (true)
            {
                Console.WriteLine("Input your name");
                workers.Name = Console.ReadLine();
                Console.WriteLine("Input your surname");
                workers.Surname = Console.ReadLine();
                Console.WriteLine("Input your otchestvo");
                workers.Otchestvo = Console.ReadLine();
                Console.WriteLine("Input your date of bitrh in format dd/MM/yyyy");
                string? Birthtext = Console.ReadLine();
                workers.Birthdate = DateTime.ParseExact(Birthtext, "dd/MM/yyyy", null);
                list.Input();
                Console.WriteLine("Input 0 to end");
                Console.WriteLine("If you want to end teacher input, enter 0. Else input something to continue");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            }
        }
    }
}
