using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PWCTestAPI.Model;

namespace PWCTestAPI.Data
{
    public class PWCTestAPIContext : DbContext
    {
        public PWCTestAPIContext (DbContextOptions<PWCTestAPIContext> options)
            : base(options)
        {
        }

        public DbSet<PWCTestAPI.Model.Client> Client { get; set; } = default!;
    }
}
