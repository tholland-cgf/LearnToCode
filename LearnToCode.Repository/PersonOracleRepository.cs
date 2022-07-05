using LearnToCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.Repository
{
    public class PersonOracleRepository
        : IPersonRepository
    {
        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPersonList(string q)
        {
            throw new NotImplementedException();
        }

        public Person Update(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
