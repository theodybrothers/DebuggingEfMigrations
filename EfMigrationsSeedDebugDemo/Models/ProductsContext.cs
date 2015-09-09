using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EfMigrationsSeedDebugDemo.Models
{
	public class ProductsContext : DbContext
	{
		public ProductsContext()
			: base("EfMigrationsSeedDebugDemo")
		{	}

		public DbSet<Product> Product { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}