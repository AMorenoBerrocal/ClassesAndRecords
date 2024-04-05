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

            //var classroomCourse = new CourseRecord(
            //    "Working with c# record", 
            //    "Alejandro"
            //    );
            //classroomCourse.Name = "Another title";
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public record CourseRecord(string Name, string Author);
     
}
