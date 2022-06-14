using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNET.Models;

namespace ASPNET.Data
{
    public class ASPNETContext : DbContext
    {
        public ASPNETContext (DbContextOptions<ASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNET.Models.Game> Game { get; set; }
    }
}
