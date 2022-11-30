
using Microsoft.Extensions.Configuration;

using Flopkart_Service.Implementation;

using Flopkart_Service.Interface;

using Flopkart_Repository.Implementation;

using Flopkart_Repository.Interface;

using Flopkart_Repository;
using Flopkart_Sql_Service.Interface;
using Flopkart_Sql_Service.Implementation;
using Flopkart_Sql_Repository.Implementation;
using Flopkart_Sql_Repository.Interface;
using Flopkart_Sql_Repository;
using Microsoft.EntityFrameworkCore;

namespace Flopkart
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<ICartService, CartService>();
            services.AddTransient<ICartRepository, CartRepository>();

            
            

            services.AddSingleton<DB_Context>(
                k => new DB_Context(Configuration.GetConnectionString("MongoDB"),
                Configuration.GetValue<string>("DatabaseName")));


            services.AddAutoMapper(typeof(IProductService));
            services.AddAutoMapper(typeof(ICartService));

            services.AddTransient<ISqlProductService, SqlProductService>();
            services.AddTransient<ISqlCartService, SqlCartService>();

            services.AddTransient<ISqlProductRepository, SqlProductRepository>();
            services.AddTransient<ISqlCartRepository, SqlCartRepository>();


            services.AddDbContext<SqlDBContext>(
                item => item.UseSqlServer(Configuration.GetConnectionString("SqlDB"))
            );
            services.AddAutoMapper(typeof(ISqlProductService));

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
               c.SwaggerEndpoint("/swagger/v1/swagger.json", "Flopkart");
            });

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllers();
            });
             
        }
    }
}
