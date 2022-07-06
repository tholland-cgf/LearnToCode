using LearnToCode.Models;
using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.Repository
{
    public class PersonFileRepository
        :IPersonRepository
    { 
        public Person Create (Person person)
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
            List<Person> list = new List<Person>();
            string _filepath;
            _filepath = @"\\ldn-cgfiles\General\Greg\LearnToCode\Files\Names.txt";
            static IEnumerable<string> GetRecordsFromFile(string filepath)
            {
                return File.ReadAllLines(filepath);
            }
            List<string> records = GetRecordsFromFile(_filepath).ToList();
            


            //using (StreamReader dr = new StreamReader(_filepath))
            //{
            //string ln;
            //while ((ln = dr.ReadLine()) != null) 
            //{
            //Person p = new Person();
            //Console.WriteLine(ln);


            //list.Add(p)
            //}
            //}
            

            return list;
            
        }
        public Person Update(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
