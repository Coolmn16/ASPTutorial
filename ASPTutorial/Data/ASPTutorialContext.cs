using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace ASPTutorial.Data
{
    public class ASPTutorialContext : DbContext
    {
        public ASPTutorialContext (DbContextOptions<ASPTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
