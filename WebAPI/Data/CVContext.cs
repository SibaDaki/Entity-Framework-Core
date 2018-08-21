using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class CVContext: DbContext
    {
        public CVContext(DbContextOptions<CVContext> options) : base(options)
        { }

        public DbSet<Person> people { get; set; }
    
    }
}
