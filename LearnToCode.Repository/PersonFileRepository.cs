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
            
            string[] records = File.ReadAllLines(_filepath);
            char[] delimiterChars = { ' ',',' };

            //Start of Sudo Code for file reading 

            //start of loop to go through records array (created buy reading contents of file) loop to carry on as long as there are lines in records.
            //take first line of array "record" 
            //split up the string at the break point (code can be heard coded to use either tab [' '] or a comma [,] or even both) 
                //take value before first break convert to integer and add as " p.Id = Convert.ToInt32(dr["Id"]);"
                //take value after first break "convert" to a string and add as "p.Name = Convert.ToString(dr["Name"]);"
                //take value after second break "Convert to interger and add as "p.Age = Convert.ToInt32(dr["Age"]);
                //add person p to the list 
            //close the loop 
            //return list 





            //while ((ln = records.ReadLine()) !=null)
            //{
            //  Console.WriteLine(ln);
            //}



            //List<string> records = GetRecordsFromFile(_filepath).ToList();


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
