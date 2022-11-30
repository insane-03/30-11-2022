using Flopkart_Sql_Repository.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flopkart_Sql_Repository
{
    public class SqlDBContext : DbContext
    {
        public SqlDBContext(DbContextOptions options) : base(options) { }
        public DbSet<SqlProducts> SqlProducts { get; set; }

    }
}
