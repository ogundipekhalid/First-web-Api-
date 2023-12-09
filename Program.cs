using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace First_web_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // short m = 32767;
            // short n = 32767;
            // int result1 = checked((short)(m + n)); //will throw an OverflowException
            // int result2 = unchecked((short)(m + n));
            // Console.WriteLine(result2);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
