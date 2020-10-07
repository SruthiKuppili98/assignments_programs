using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpLinq
{
    public class Program
    {
        static void Main(string[] args)

        {
            IList<Employee> employeeList = new List<Employee>()
            {
            new Student() { EmployeeID = 2, EmployeeName = "Sruthi", Age = 21, Destination = 1 },
            new Student() { EmployeeID = 3, EmployeeName = "haritha", Age = 22, Destination = 2 },
            new Student() { EmployeeID = 4, EmployeeName = "aditi", Age = 21, Destination = 3 },
            new Student() { EmployeeID = 5, EmployeeName = "Sravani", Age = 22, Destination = 4 },
        };
            var StudentName = studentList.Where(s => s.Age > 18).Select(s => s).Where(st => st.Destination > 1).Select(s => s.EmployeeName);
            var StudentName1 = studentList.Where(s => s.Age > 22).Select(s => s).Where(st => st.Destination > 4).Select(s => s.EmployeeName);
            foreach (var name in EmployeeName)
            {
                Console.WriteLine(name);
            }
            foreach (var name1 in EmployeeName1)
            {
                Console.WriteLine(name1);
                Console.ReadKey();
            }
        }
    }
}