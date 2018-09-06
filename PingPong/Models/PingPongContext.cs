using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PingPong.Models
{
    public class PingPongContext : DbContext
    {
        public PingPongContext(DbContextOptions<PingPongContext> options) 
            : base(options)
        { }

        public DbSet<Player> Players { get; set; }
    }
}
