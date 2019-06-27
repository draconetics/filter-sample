using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sample.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Persona> Persona { get; set; }
    }
}