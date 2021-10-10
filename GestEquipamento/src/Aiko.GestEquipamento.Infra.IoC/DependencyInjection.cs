using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Application.Services;
using Aiko.GestEquipamento.Domain.Interfaces;
using Aiko.GestEquipamento.Infra.Data.Context;
using Aiko.GestEquipamento.Infra.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aiko.GestEquipamento.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext)
                        .Assembly.FullName)));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddControllersWithViews();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IEquipmentModelService, EquipmentModelService>();
            services.AddTransient<IEquipmentStateService, EquipmentStateService>();
            services.AddTransient<IEquipmentService, EquipmentService>();

            return services;
        }
    }
}