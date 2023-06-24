using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23_06_2023
{
    public class Employee
    {

        public Guid Id { get; set; } = Guid.NewGuid();    

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public Employee(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public static void AddFiles(string basePath, string fileName, List<string> files)
        {
            for (int i = 1; i <= 10; i++)
            {
                string path = Path.Combine(basePath, fileName + $"{i}.txt");
                files.Add(path);

                FileInfo fileInfo = new FileInfo(path);

            }
        }

        public static void AddUserToFile(string path, Employee employee)
        {
            string employeeInfo = $"Id: {employee.Id}" +
                $"\nFirst name: {employee.FirstName}" +
                $"\nLast name: {employee.LastName}" +
                $"\nPhone number: {employee.PhoneNumber}" +
                $"\nEmail address: {employee.Email}";

            File.WriteAllText(path, employeeInfo);
        }
    }
}
