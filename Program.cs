internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Ciao da Omnia!");
        app.UseStaticFiles();
        app.Run();
        
    }
}