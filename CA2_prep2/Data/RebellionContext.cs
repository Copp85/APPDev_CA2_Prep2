using CA2_prep2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA2_prep2.Data
{
    public class RebellionContext : DbContext
    {
        public RebellionContext(DbContextOptions<RebellionContext> options)
            : base(options)
        {

        }
        public DbSet<Browncoat> BrownCoats { get; set; }
    }
}
