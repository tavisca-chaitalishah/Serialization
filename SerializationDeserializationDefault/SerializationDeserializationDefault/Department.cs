using System;
using System.Xml.Serialization;

namespace SerializationDeserializationDefault
{
    
    public class Department
    {
      
        public int department_Id { get; set; }
     
        public string departmentName { get; set; }
        public Department()
        {

        }
        public Department (int department_Id, string departmentName)
        {
            this.department_Id = department_Id;
            this.departmentName = departmentName;
        }
    }
}