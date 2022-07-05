using LearnToCode.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.Repository
{
    public class PersonSqlRepository
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
            List<Person> list = new List<Person>();

            using (SqlConnection cnn = new SqlConnection("Data source=ldn-devsql16;database=test;integrated security=true"))
            {
                cnn.Open();
                using (SqlCommand cmm = new SqlCommand())
                {
                    cmm.Connection = cnn;
                    cmm.CommandText = "GetPeopleList";
                    cmm.CommandType = System.Data.CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@where","1=1");
                    using (SqlDataReader dr = cmm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new Person
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Name = Convert.ToString(dr["Name"]),
                                Age = Convert.ToInt32(dr["Age"])

                            });
                        }
                    }
                }

                return list;
            }
        }

        public Person Update(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
