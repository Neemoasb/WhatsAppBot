using Infra.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace WhatsAppProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ServiceProvider serviceProvider = DependencyInjectionConfig.ConfigureServices();
            ApplicationConfiguration.Initialize();
            var service = serviceProvider.GetService<IMensagensRepository>();
            Application.Run(new Form1(service));
        }

    }
}