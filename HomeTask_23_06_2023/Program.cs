using System.IO;

namespace HomeTask_23_06_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory("CreateDirectory");

            string fileName = "file";
            string basePath = "C:\\Users\\USER\\Desktop\\Dasturlash\\DotNetBootcamp\\HomeTask-Group-N7\\HomeTask_23_06_2023\\bin\\Debug\\net7.0\\CreateDirectory";

            List<string> files = new List<string>();

            // Bu method Directoriyaga file qoshib beradi.

            Employee.AddFiles(basePath, fileName, files);

            List<Employee> employees = new List<Employee>();

            employees.AddRange(new[]
            {
                new Employee("Sanjarbek", "Nasvaliyev", "944390120", "sanjarbek@gamil.com"),
                new Employee("Jasur", "Ubaydullayev", "932220553", "jasur@gmail.com"),
                new Employee("Hamdam", "Nosirov", "901911232", "hamdam@gmail.com"),
                new Employee("Lazizbek", "Xoshiov", "991233421", "laziz@gmail.com"),
                new Employee("Shoxrux", "Xotamov", "930912003", "shoxrux@gmail.com"),
                new Employee("Jamshid", "Asadov", "901212234", "jamshid@gmail.com"),
                new Employee("Ijodbek", "Abdurahmonov", "906080208", "ijod@gmail.com"),
                new Employee("Bahriddin", "Abdusalomov", "944396669", "bahriddinabdusalomov@gmail.com"),
                new Employee("Davronbek", "Toxtamatov", "945552905", "davron@gmail.com"),
                new Employee("Arabboy", "Xamraliyev", "9455055150", "arabboy@gmail.com")
            });

            int count = 0;
            foreach (var item in employees)
            {
                Employee.AddUserToFile(files[count++], item);
            }

        }
    }
}
