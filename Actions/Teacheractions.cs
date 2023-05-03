using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studteachworkers.University;

namespace Studteachworkers.Actions
{
    public class Teacheractions
    {
        Studentlist studs = new Studentlist();
        public void actions(int Choosenumber)
        {
            switch (Choosenumber)
            {
                case 1:
                    Console.WriteLine("Введите группу и предмет, который вы проведёте в качестве экзамена");
                    string group = Console.ReadLine();
                    string subject = Console.ReadLine();
                    var list = studs.GetList();
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
