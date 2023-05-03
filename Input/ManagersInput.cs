using Studteachworkers.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.Input
{
    internal class ManagersInput
    {
        Managers manager = new Managers();
        Managerlist list = new Managerlist();
        public void Managersinput()
        {
            while (true)
            {
                Console.WriteLine("Input your name");
                manager.Name = Console.ReadLine();
                Console.WriteLine("Input your surname");
                manager.Surname = Console.ReadLine();
                Console.WriteLine("Input your otchestvo");
                manager.Otchestvo = Console.ReadLine();
                Console.WriteLine("Input your date of bitrh in format dd/MM/yyyy");
                string? Birthtext = Console.ReadLine();
                manager.Birthdate = DateTime.ParseExact(Birthtext, "dd/MM/yyyy", null);
                Console.WriteLine("Now input your orders to students/ teachers/ workers that you've done");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "0")
                    {
                        Console.WriteLine("You ended your input of subjects");
                        break;
                    }
                }
                list.Input();
                Console.WriteLine("If you want to end manager input, enter 0. Else continue after some input");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
                
            }
        }
    }
}
