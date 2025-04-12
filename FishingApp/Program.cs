
using DAL;
using FishingApp.BAL;
using FishingApp.Repository;

namespace FishingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            string cs = builder.Configuration.GetConnectionString("DB");
            builder.Services.AddScoped<ISqlHelper>(p => new SqlHelper(cs));

            builder.Services.AddScoped<ILoginRepository, LoginRepository>();
            builder.Services.AddScoped<ILoginBAL, LoginBAL>();

            builder.Services.AddScoped<ILocationRepository, LocationRepository>();
            builder.Services.AddScoped<ILocationBAL, LocationBAL>();

            builder.Services.AddScoped<ISellerRepository, SellerRepository>();
            builder.Services.AddScoped<ISellerBAL, SellerBAL>();

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ICustomerBAL, CustomerBAL>();

            builder.Services.AddCors(s => s.AddPolicy("corsPolicy", q => {
                q.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }));



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("corsPolicy");



            app.MapControllers();

            app.Run();
        }
    }
}