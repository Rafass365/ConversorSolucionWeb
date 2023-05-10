namespace ConversorProyecto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //app.UseWelcomePage();
            app.UseStaticFiles();       //


   


            app.Run();
            //Console.WriteLine("Rafaelito´s");
        }
    }
}