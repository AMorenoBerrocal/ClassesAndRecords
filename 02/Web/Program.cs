using System;
using System.Net.Http;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Web.Mappers;

namespace Web
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "Working with c# records";
            pluralsightCourse.Author = "Alejandro";
            var (name, author) = pluralsightCourse;
            Console.WriteLine(name);
            Console.WriteLine(author);

            var classroomCourse = new CourseRecord(
                "Working with c# records", "Alejandro");

            var anotherCourse = classroomCourse with { Name = "C# getting started", Description = "Alberto" };

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(
                sp => new HttpClient {BaseAddress = new Uri("https://localhost:5002")});
            builder.Services.AddSingleton<EventMapper>();

            await builder.Build().RunAsync();
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public void Deconstruct(out string name, out string author)
        {
            name = Name;
            author = Author;
        }


    }
    public record CourseRecord(string Name, string Description)
    {

        public string Name { get; init; }
        public string Author { get; init; }
        public string Title
        {
            get {
                return $"{Name} - {Description}";
            }
        }
    }

    public record TimedCourseRecord(string Name, string Author, int Duration) : CourseRecord(Name, Author)
    {
        public string Vennue { get; set; }
        public virtual bool Equals(TimedCourseRecord other)
        {
            //
            //return Name = other.Name;
            return true;
        }
    } 
}