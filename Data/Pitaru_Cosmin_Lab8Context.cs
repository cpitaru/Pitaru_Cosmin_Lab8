using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pitaru_Cosmin_Lab8.Models;

namespace Pitaru_Cosmin_Lab8.Data
{
    public class Pitaru_Cosmin_Lab8Context : DbContext
    {
        public Pitaru_Cosmin_Lab8Context (DbContextOptions<Pitaru_Cosmin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pitaru_Cosmin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pitaru_Cosmin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pitaru_Cosmin_Lab8.Models.Category> Category { get; set; }
    }
}
