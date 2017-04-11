using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationDeserializationDefault
{
    [Serializable]
    public class Person
    {
       
        public string firstName { get; set; }
     
        public string lastName { get; set; }
     
        public int person_Id { get; set; }
       public Person()
        {

        }
       public Person(string firstName , string lastName , int personId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.person_Id = personId;

        }
    }

   
}
