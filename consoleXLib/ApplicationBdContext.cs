using System;
using Microsoft.EntityFrameworkCore;

namespace consoleXLib
{
    public class ApplicationBdContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
           optionsBuilder.UseSqlServer("Data Source=DESKTOP-LDMN0NB\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True");

        public DbSet<Book> Books { get; set; }
        public DbSet<BookState> BookStates { get; set; }
        public DbSet<Laibrarian> Laibrarians { get; set; }
        public DbSet<MainCategory> MainCategorys { get; set; } 
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }
        public DbSet<User> Users { get; set; }



    }
}

