using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class ConfigureSQL
    {
        static public DbContextOptions<DalContext> options = new DbContextOptionsBuilder<DalContext>()
            .UseSqlServer("Server=mssqlstud.fhict.local;Database=dbi454010;User Id=dbi454010;Password=70Cent;")
            .Options;
    }
}
