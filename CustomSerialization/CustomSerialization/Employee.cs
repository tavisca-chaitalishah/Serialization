using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerialization
{
    [Serializable]
    public class Employee : ISerializable, IDeserializationCallback
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
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Person Info", person);
            info.AddValue("Employee Information", employee_Id);
            info.AddValue("Department Information", department);
        }

        public void OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }

        public Employee(SerializationInfo info, StreamingContext context)
        {
            employee_Id = info.GetInt32("Employee Information");
            person = (Person)info.GetValue("Person Info", typeof(Person));
            department = (Department)info.GetValue("Department Information", typeof(Department));


        }
    }
}

