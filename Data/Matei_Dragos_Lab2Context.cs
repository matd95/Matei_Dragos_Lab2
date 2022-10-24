using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Matei_Dragos_Lab2.Models;

namespace Matei_Dragos_Lab2.Data
{
    public class Matei_Dragos_Lab2Context : DbContext
    {
        public Matei_Dragos_Lab2Context (DbContextOptions<Matei_Dragos_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Matei_Dragos_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Matei_Dragos_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
