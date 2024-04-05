using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndRecords
{
    class Program
    {

        static void PrintCourse(Course course)
        {
            Console.WriteLine(course.Name);
        }

        static void Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "Working with c# records";
            pluralsightCourse.Author = "Alejandro";

            PrintCourse(pluralsightCourse);

            var anotherCourse = pluralsightCourse;

            Console.WriteLine(pluralsightCourse.Name);
            Console.WriteLine(anotherCourse.Author);

        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
