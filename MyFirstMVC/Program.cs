using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MyFirstMVC
{
    public class Program
    {
        //static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //Parallel.F
            //Thread thread = new Thread(printDat);
            //thread.st
            
        }
        public static void printDat()
        {
            Console.WriteLine("Print data");
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
