using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPracticePerson.Models
{
    internal class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public Passport Passport { get; set; }
    }
}
