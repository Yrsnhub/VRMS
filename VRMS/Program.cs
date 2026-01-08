using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using VRMS.Database;
using VRMS.Terminal;

namespace VRMS
{
    internal static class Program
    {
        
        public static string CurrentUsername { get; set; } = "Guest";
        public static string CurrentUserRole { get; set; } = "User";

        [STAThread]
        static void Main(string[] args)
        {
           
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = config.GetConnectionString("Default");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "Connection string 'Default' is missing in appsettings.json");
            }

            DB.Initialize(connectionString);

            if (CommandDispatcher.TryExecute(args))
                return;

            ApplicationConfiguration.Initialize();

            Application.Run(new Welcome());
        }
    }
}
