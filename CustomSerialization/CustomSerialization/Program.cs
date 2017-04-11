using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Chaitali", "Shah", 810);
            Department department = new Department(12, "developer");
            Employee employee = new Employee(person, 1, department);
            List<Employee> employees = new List<Employee>();
            for (int iterator = 0; iterator < 100; iterator++)
            {
                employees.Add(employee);
            }
            Company tavisca = new Company(employees);

            JsonSerializationFunction(tavisca);
            XmlSerializationFunction(tavisca);


            Console.ReadLine();
        }
        public static void JsonSerializationFunction(Company employee)
        {
            
            Stopwatch jsonWatch = new Stopwatch();
            jsonWatch.Start();
            for (int iterator = 0; iterator < 1000; iterator++)
            {
                var jsonString = JsonSerialization.ConvertObjectToJson(employee);
            JsonConvert.DeserializeObject<Employee>(jsonString);
            }

            jsonWatch.Stop();
            Console.WriteLine(jsonWatch.ElapsedMilliseconds);
        }
        public static void XmlSerializationFunction(Company employee)
        {
            Stopwatch xmlWatch = new Stopwatch();
            xmlWatch.Start();
            for (int iterator = 0; iterator < 1000; iterator++)
            {
                XmlSerializationClass.ObjectToXml(employee);
                XmlSerializationClass.XmlToObjectNotation();
            }
            xmlWatch.Stop();
            Console.WriteLine(xmlWatch.ElapsedMilliseconds);

        }
    }
}
