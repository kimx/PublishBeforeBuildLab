namespace PublishBeforeBuildLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World Main 1!");

            app.Run();
        }
    }
}