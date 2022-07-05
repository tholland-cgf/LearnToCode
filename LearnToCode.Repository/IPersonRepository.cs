using LearnToCode.Models;


namespace LearnToCode.Repository
{
    public interface  IPersonRepository
    {

        Person GetPerson(int id);
        IEnumerable<Person> GetPersonList(string q);
        public Person Update(int id, Person person);
        public Person Create(Person person);
        public void Delete(int id);
    }
}