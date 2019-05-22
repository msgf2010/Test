using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace URLShortner.Data
{
    public class URLContext : DbContext
    {
        private string _connectionString;

        public URLContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
