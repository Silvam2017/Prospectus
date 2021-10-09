using Microsoft.EntityFrameworkCore;
using Prospectus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prospectus.Data
    // configuration for DB Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // Create Table with Player Name
        public DbSet<Player> Player { get; set; }
        // add-migration AddPlayerTableToDatabase via entityframework.tools
        // update-database to push pending migrations
    }
}
