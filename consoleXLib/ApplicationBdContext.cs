using System;
using Microsoft.EntityFrameworkCore;

namespace consoleXLib
{
    public class ApplicationBdContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=consoleXLib.db");
        }
    }
}
