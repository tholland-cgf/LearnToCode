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
            
            string[] records = System.IO.File.ReadAllLines(_filepath);
            char[] delimiterChars = { '\t',',' };

            //Start of Sudo Code for file reading 



            //var lines = System.IO.File.ReadAllLines(_filepath);
            //start of loop to go through records array (created buy reading contents of file) loop to carry on as long as there are lines in records.
            //string line = "Terry,Holland,50";
           
            foreach(var item in records)
            {
                var splitrec = item.Split(delimiterChars);
                var p = new Person();
                p.Id = Convert.ToInt32(splitrec[0]);
                p.Name = Convert.ToString(splitrec[1]);
                p.Age = Convert.ToInt32(splitrec[2]);

                list.Add(p);
            }

            return list;

            

            //Example Sudo code use this to get the process/logic straight in your head before actual coding.
            //take first line of array "record" 
            //split up the string at the break point (code can be heard coded to use either tab [' '] or a comma [,] or even both) 
            //take value before first break convert to integer and add as " p.Id = Convert.ToInt32(dr["Id"]);"
            //take value after first break "convert" to a string and add as "p.Name = Convert.ToString(dr["Name"]);"
            //take value after second break "Convert to interger and add as "p.Age = Convert.ToInt32(dr["Age"]);
            //add person p to the list 
            //close the loop 
            //return list 



        }
        public Person Update(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
