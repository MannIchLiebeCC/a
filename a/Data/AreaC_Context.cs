using Microsoft.EntityFrameworkCore;
using a.Models;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace a.Data
{
    public class AreaC_Context : DbContext
    {

        public AreaC_Context(DbContextOptions options) : base(options) 
        { 

        }
        public DbSet<AR_Categories> AR_DB { get; set; }
        public DbSet<GP_Categories> GP_DB { get; set; }
        public DbSet<L_Categories> L_DB { get; set; }
    }
        
}
