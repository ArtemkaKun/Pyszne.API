using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Pyszne_API.APISystem;

namespace Pyszne_API
{
	public static class Program
	{
		private static APIManager API { get; } = new();
		
		public static void Main (string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		private static IHostBuilder CreateHostBuilder (string[] args)
		{
			return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
		}
	}
}