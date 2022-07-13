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
            //Get the filtered list 
            //Navigate to directry on file sever 
            //create a text file (along the line of search_results.txt, maybe something to check if file exists and take a appropriate action) 
            //open the file
            //write contents of filtered list to file 
                        //2 options, could either write each "Field" as we go, placing the delimiter between each "field" as you go, or 
                        //stitch the values of ID, Name and Age together in a string and write the string to the file. 
            //Save the file
            //Close the file 
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
            //create list
            List<Person> list = new List<Person>();
            //define the location of file to be read
            string _filepath;
            _filepath = @"\\ldn-cgfiles\General\Greg\LearnToCode\Files\Names.txt";
            //read file and define delimiter characters, in this cas a tab or comma
            string[] records = System.IO.File.ReadAllLines(_filepath);
            char[] delimiterChars = { '\t',',' };

           //loop to read through each line of string array "records"
            foreach(var item in records)
            {
                //split string based on delimiter used into seperate arrays 
                var splitrec = item.Split(delimiterChars);
                //create new person 
                var p = new Person();
                //convert string value in relevent array to one required by variable 
                p.Id = Convert.ToInt32(splitrec[0]);
                p.Name = Convert.ToString(splitrec[1]);
                p.Age = Convert.ToInt32(splitrec[2]);
                //add all varilables to the list created above 
                list.Add(p);
            }
            //return list. 

            return list;


            //working out stuff 
            //var lines = System.IO.File.ReadAllLines(_filepath);
            //start of loop to go through records array (created buy reading contents of file) loop to carry on as long as there are lines in records.
            //string line = "Terry,Holland,50";
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
