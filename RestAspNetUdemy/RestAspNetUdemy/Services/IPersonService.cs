using RestAspNetUdemy.Model;
using System.Collections.Generic;
    
namespace RestAspNetUdemy.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        Person Update(Person person);
        List<Person> FindAll();
        void Delete(long id);
    }
}
