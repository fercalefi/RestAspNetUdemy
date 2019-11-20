using System;
using System.Collections.Generic;
using System.Threading;
using RestAspNetUdemy.Model;

namespace RestAspNetUdemy.Services.Implementations
{
    public class PersonServiceImp : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);

            }
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Fernando" + i,
                LastName = "Calefi" + i,
                Address = "Ida Roncolato Nogueira 180" + i,
                Gender = "Male"
            };

        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Fernando",
                LastName = "Calefi",
                Address = "Ida Roncolato Nogueira 180",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
