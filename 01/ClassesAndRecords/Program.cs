using System;

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
            pluralsightCourse.Name = "Working with C# records";
            pluralsightCourse.Author = "Alejandro";

            var classroomCourse = new CourseRecord("Another title", "Alejandro");
            // No necesitas asignar a la propiedad Name ya que estás usando registros

            PrintCourse(classroomCourse); // Esta línea imprime "Another title"
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public record CourseRecord(string Name, string Author);
}
