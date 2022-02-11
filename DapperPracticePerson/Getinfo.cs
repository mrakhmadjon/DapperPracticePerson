using DapperPracticePerson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPracticePerson
{
    internal class Getinfo
    {
        public static Person GetInfoUpdate()
        {
           

            Console.WriteLine("Yangilamoqchi bolgan Personni Id sini kiriting ");

            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Firstname");
            string firstname = Console.ReadLine();

            Console.WriteLine("Lastname");
            string lastname = Console.ReadLine();

            Console.WriteLine("Age");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Passport Seriyasi");
            string seria = Console.ReadLine();

            Console.WriteLine("Seriya Raqam");
            int seriyaRaqam = int.Parse(Console.ReadLine());

            Passport passport = new Passport()
            {
                Seria = seria,
                Number = seriyaRaqam
            };


            Person person = new Person()
            {
                Id = id,
                FirstName = firstname,
                Lastname = lastname,
                Age = age,
                Passport = passport 
            };

            return person;
        }

        public static int GetId ()
        {
            Console.WriteLine("Id ni kiriting");
            int id = int.Parse (Console.ReadLine());
            return id;
        }
    }
}
