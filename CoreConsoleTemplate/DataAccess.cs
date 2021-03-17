using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleTemplate
{
    public class DataAccess : IDataAccess
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<DataAccess> _logger;

        public DataAccess(IConfiguration configuration, ILogger<DataAccess> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        private string GetCS(string name = "ConnectionString")
        {
            return _configuration.GetConnectionString("ConnectionString");
        }

        //methods
    }
}
