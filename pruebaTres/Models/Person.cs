using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaTres.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>()
{
new Person
{
Id = 1,
FirstName = "Michael", LastName = "Pitt",
Age = 32,
Country = "Germany"
},
new Person
{
Id = 2,
FirstName = "Sabrina", LastName = "Morales", Age = 6,
Country = "Ecuador"
},
new Person
{
Id = 3,
FirstName = "Rodrigo", LastName = "Vela",
Age = 54,
Country = "Peru"
},
new Person
{
Id = 4,
FirstName = "Lorena", LastName = "Perez", Age = 18,
Country = "Bolivia"
},
new Person
{
Id = 5,
FirstName = "Pablo", LastName = "Picasso", Age = 19,
Country = "Spain"
},
new Person
{
Id = 6,
FirstName = "Walter", LastName = "Misagi", Age = 17,
Country = "Japan"
},
};
            return persons;
        }
    }

}
