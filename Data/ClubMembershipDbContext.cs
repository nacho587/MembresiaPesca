using MembresiaPesca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembresiaPesca.Data
{
    public class ClubMembershipDbContext:DbContext // puente entre applicacion y BdD
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}ClubMembershipDb.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; } //representa una tabla en la base de datos donde cada fila es un objeto User
    }
}
