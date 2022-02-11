using Dapper;
using DapperPracticePerson.Data;
using DapperPracticePerson.Models;
using DapperPracticePerson.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperPracticePerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonRepository rep = new PersonRepository();


            #region Create
            //Passport pas = new Passport()
            //{
            //    Seria = "AB",
            //    Number = 103
            //};
            //Person person = new Person()
            //    {
            //        FirstName = "Kamron",
            //        Lastname = "Alisherov",
            //        Age = 30,
            //       Passport = pas

            //    };

            //rep.Create(person);




            #endregion

            #region Get

            Console.WriteLine("Id ");
            int id = int.Parse(Console.ReadLine());
            Person per = rep.Get(id);
            Console.WriteLine(per.Id + " " + per.FirstName + " " + per.Lastname + " " + per.Passport.Seria+per.Passport.Number);

            Console.WriteLine();
            #endregion


            #region Update

            //rep.Update(Getinfo.GetInfoUpdate());

            #endregion

            #region Delete

            //rep.Delete(Getinfo.GetId());

            #endregion



            #region GetAll

            //var people = rep.GetAll();

            //foreach (Person person in people)
            //    Console.WriteLine($"{person.Id}  {person.FirstName} {person.Lastname}  {person.Passport.Seria}{person.Passport.Number}");

            #endregion
        }
    }
}
