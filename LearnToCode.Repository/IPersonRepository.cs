using LearnToCode.Models;


namespace LearnToCode.Repository
{
    public interface  IPersonRepository
    {

        Person GetPerson(int id);
        IEnumerable<Person> GetPersonList(string q);//implement this
        public Person Update(int id, Person person);
        public Person Create(Person person);
        public void Delete(int id);
    }


    public interface IPersonRepository2
        : IPersonRepository
    {

        public Person Create(IEnumerable<Person> person);
        
    }
}