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
    public record CourseRecord(string Name, String Description);
}