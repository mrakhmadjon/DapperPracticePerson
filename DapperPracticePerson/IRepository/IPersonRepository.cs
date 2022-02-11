using DapperPracticePerson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPracticePerson.IRepository
{
    internal interface IPersonRepository
    {
        void Create(Person person);

        Person Get(int _id);

        void Update(Person pr);

        public void Delete(int id);

    }
}
