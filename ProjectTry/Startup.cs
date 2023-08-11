using Google;
using Microsoft.EntityFrameworkCore;
using ProjectTry.Coree.Interfaces;
using ProjectTry.Infrastructure.Repositories;
using ProjectTry.Infrastructuree.Repositories;



namespace ProjectTry
{
    public class Startup
    {

        /*  public Startup(IConfiguration configuration)
          {
              Configuration = configuration;
          }

          public IConfiguration Configuration { get; }

          // This method gets called by the runtime. Use this method to add services to the container.
          public void ConfigureServices(IServiceCollection services)
          {
              services.AddControllers();
              services.AddDbContext<ApplicationContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection"),
                  b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

              #region Repositories
              services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
              //services.AddTransient<IDeveloperRepository, DeveloperRepository>();
              //services.AddTransient<IProjectRepository, ProjectRepository>();
              services.AddTransient<IProductRepository, ProductRepository>();
              #endregion
              services.AddTransient<IUnitOfWork, UnitOfWork>();
          }

          // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
          public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
          {
              if (env.IsDevelopment())
              {
                  app.UseDeveloperExceptionPage();
              }

              app.UseHttpsRedirection();

              app.UseRouting();

              app.UseAuthorization();

              app.UseEndpoints(endpoints =>
              {
                  endpoints.MapControllers();
              }); 

          }
        */
    }

}
