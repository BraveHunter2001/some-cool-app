using DAL;
using Services;

namespace some_cool_app;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        string connectionString = builder.Environment.IsDevelopment()
            ? "Server=localhost;Port=5432;Database=someCool;User ID=pguser;Password=pgadmin;"
            : "Server=postgres;Port=5432;Database=someCool;User ID=pguser;Password=pgadmin;";

        // Add services to the container.
        builder.Services.AddDAL(connectionString);
        builder.Services.AddService();

        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}