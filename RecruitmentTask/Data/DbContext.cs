
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace RecruitmentTask.Data
{
	public class RecruitmentTaskDbContext : DbContext
	{
		public DbSet<Team> Teams { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<VacationPackage> VacationPackages { get; set; }
		public DbSet<Vacation> Vacations { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RecruitmentTaskDb;Trusted_Connection=True;");
		}
	}
}
