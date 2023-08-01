using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store.Model;

namespace Store.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext (DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Store.Model.Product> Product { get; set; } = default!;

        public DbSet<Store.Model.Student>? Student { get; set; }

       
    }
}
