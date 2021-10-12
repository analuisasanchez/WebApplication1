using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class EstudioDBContext: DbContext 
    {
         public EstudioDBContext (DbContextOptions<EstudioDBContext>options):base(options)
        { 

        }
         public DbSet<WebApplication1.Models.Music> Songs { get; set; }
        public object Music { get; internal set; }
    }
}
