using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDeserializationDefault
{
    public class Company
    {

        public Employee employee { get; set; }
        public List<Employee> companyEmployee { get; set; }
        public Company(List<Employee> employees)
        {
            companyEmployee = employees;
        }
        public Company()
        {

        }
    }
}
