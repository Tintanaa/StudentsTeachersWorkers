using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studteachworkers.University
{
    internal interface IPeople
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Otchestvo { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
