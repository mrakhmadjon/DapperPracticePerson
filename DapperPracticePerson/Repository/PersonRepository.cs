using Dapper;
using DapperPracticePerson.IRepository;
using DapperPracticePerson.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPracticePerson.Repository
{
    internal class PersonRepository : IPersonRepository
    {
        IDbConnection db = new SqlConnection(Constants.DATAPATH);

        public void Create (Person person)
        {
            try
            {
                string insQuery = $"insert into passport (seria,number)values('{person.Passport.Seria}',{person.Passport.Number})";
                string sql = $"insert into person (firstname, lastname,age,passportId)values('{person.FirstName}', '{person.Lastname}', {person.Age}, (select top 1 id from passport where number = {person.Passport.Number}))";


                db.Query(insQuery);

                int a = db.Execute(sql);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }


        public Person Get (int _id)
        {
            try
            {
                Person person = GetAll().Where(p => p.Id == _id).FirstOrDefault();
                return person;
            }
            catch (Exception)
            {

                throw new Exception();
            }
          
          
        }

        public IEnumerable<Person> GetAll()
        {
            string pasQuery = "select * from passport";
            var passports = db.Query<Passport>(pasQuery);

            string peopQuery = "select * from person";
            var people = db.Query<(int id, string firstname, string lastname, int age, int passId)>(peopQuery);

            var result = new List<Person>();

            foreach (var person in people)
            {
                var id = passports.FirstOrDefault(p => p.Id == person.passId);

                result.Add(new Person
                {
                    Id = person.id,
                    FirstName = person.firstname,
                    Lastname = person.lastname,
                    Age = person.age,
                    Passport = id
                });
            }
            return result;
        }

        public void Update (Person pr)
        {
            try
            {
                string insQuery = $"insert into passport (seria,number)values('{pr.Passport.Seria}',{pr.Passport.Number})";

                string query = $"update person set firstname = '{pr.FirstName}',lastname = '{pr.Lastname}',age = {pr.Age},passportId = (select top 1 id from passport where number = {pr.Passport.Number}) where id = {pr.Id}";

                db.Query<Passport>(insQuery);

                db.Query<Person>(query);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
        }

        public void Delete (int id)
        {
            try
            {
                string query = $"delete from person where id = {id}";

                db.Query(query).FirstOrDefault();

            }
            catch (Exception ex) 
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
