using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerialization
{
    [Serializable]
    public class Department
    {

        public int department_Id { get; set; }

        public string departmentName { get; set; }
        public Department()
        {

        }
        public Department(int department_Id, string departmentName)
        {
            this.department_Id = department_Id;
            this.departmentName = departmentName;
        }
    }
}