
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using Microsoft.Extensions.Configuration;
using SqlKata.Compilers;
using SqlKata.Execution;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace server.Utility.SqlKata
{
    public static class QueryBuilder
    {
        public static QueryFactory Init()
        {
            var connection = new SqlConnection("Data Source=MISMONIR\\SQLEXPRESS;Database=dbFixedAsset;User ID=sa;Password=dataport;");
            var compiler = new SqlServerCompiler();
            return new QueryFactory(connection, compiler);
        }
    }
}
