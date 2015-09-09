using System.Web;
using System.Web.Mvc;

namespace EfMigrationsSeedDebugDemo
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
