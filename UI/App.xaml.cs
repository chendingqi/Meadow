using Data;
using Data.Context;
using Data.IRepository;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service;
using Service.IService;
using Service.Service;
using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace UI
{
    /// <summary>
    /// App.xaml的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider serviceProvider { get; private set; }
        public IConfiguration configuration { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();
            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
        private void ConfigureServices(IServiceCollection services)
        {
            Assembly appServiceAssembly = Assembly.GetExecutingAssembly();

            services.AddScoped(
                typeof(IRepository<>),
                typeof(Repository<>));
            services.AddScoped(
                typeof(IService<>),
                typeof(Service<>));

            //services.AddScoped<IUsersRepository, UsersRepository>();

            //services.AddScoped<IUsersService, UsersService>();
            services.AddMyAppRepository();
            services.AddMyAppServices();

            services.AddDbContext<MeadowContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlConnection")));
            services.AddTransient(typeof(MainWindow));
        }
    }
}
