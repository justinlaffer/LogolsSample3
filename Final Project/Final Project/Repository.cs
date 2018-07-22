using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Final_Project
{
    public class repository
    {
        private string connectionString;

        public repository()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var connectionStringConfig = builder.Build();
            connectionString = connectionStringConfig.GetConnectionString("DefaultConnection");
        }
        
        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
}