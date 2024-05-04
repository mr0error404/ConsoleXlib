using System;
using Microsoft.EntityFrameworkCore;

namespace consoleXLib
{
	public class ApplicationBdContext:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
           optionsBuilder.UseSqlServer("Data Source=DESKTOP-LDMN0NB\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True");
	}
}

