using AtiCrm.Datalayer;
using Microsoft.EntityFrameworkCore;

namespace AtiCrm.Api
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
            builder.Services.AddDbContext<CrmDbContext>(o => o.UseSqlServer("server=.;database=aticrm;trusted_connection=yes"));

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "CORS",
                                  policy =>
                                  {
                                      policy.WithOrigins("http://localhost:4200");
                                      policy.WithHeaders("Content-type");
                                  });
            });


            AtiCrm.BLL.DepencyRegister.Register(builder.Services);
            AtiCrm.Datalayer.DepencyRegister.Register(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("CORS");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}