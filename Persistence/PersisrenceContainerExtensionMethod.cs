using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Data;
using Persistence.Data.Repository;
using Persistence.Services;

namespace Persistence
{
    public static class PersisrenceContainerExtensionMethod
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped(typeof(ISpecification<>), typeof(Specification<>));
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUOW, UOW>();
            //  services.AddSingleton<UpdateAuditableEntitiesInterceptor>();
            services.AddDbContext<SallaryCQRSAppContext>((sp, opt) =>
            {
                //  var auditableInterceptor = sp.GetService<UpdateAuditableEntitiesInterceptor>()!;
                //  opt.AddInterceptors(auditableInterceptor)
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
                    , o => o.MigrationsAssembly("Web.Api")

                    .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
                opt.EnableSensitiveDataLogging(true);

                // .AddInterceptors(auditableInterceptor);
            });

            return services;
        }
    }
}
