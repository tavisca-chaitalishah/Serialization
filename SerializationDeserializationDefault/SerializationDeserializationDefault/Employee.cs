using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationDeserializationDefault
{

    public class Employee
    {

        public Person person { get; set; }

        public int employee_Id { get; set; }

        public Department department { get; set; }
        public Employee()
        {

        }
        public Employee(Person person, int employee_Id, Department department)
        {
            this.person = person;
            this.employee_Id = employee_Id;
            this.department = department;
        }

    }
}

