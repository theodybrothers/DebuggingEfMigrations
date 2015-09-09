namespace EfMigrationsSeedDebugDemo.Migrations
{
	using EfMigrationsSeedDebugDemo.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<EfMigrationsSeedDebugDemo.Models.ProductsContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(EfMigrationsSeedDebugDemo.Models.ProductsContext context)
		{
			if (System.Diagnostics.Debugger.IsAttached == false)
				System.Diagnostics.Debugger.Launch();	

			context.Product.Add(
				new Product()
			);

			context.SaveChanges();
		}
	}
}
