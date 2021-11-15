using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSortiranjeIvanMočilac15112021
{
    class Program
    {
       static void Main(string[] args) { 
 		List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob", Age = 19  },
            };
            var godinastudenta = from s in studentList
                            orderby s.Age descending
                            select s;

            foreach (Student std in godinastudenta)
            {
                if (std.Age > 12 && std.Age < 20)
                {
                    Console.WriteLine(std.StudentID + " " + std.StudentName + " " + std.Age);
                }
            }
            Console.ReadKey();
        }
}
}

public class Student
{
    public int Age { get; set; }
    public int StudentID { get; set; }
	public string StudentName { get; set; }
}