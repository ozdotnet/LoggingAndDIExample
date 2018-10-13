using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NLog;
using NLog.Web;
using System;

namespace CoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //NLog: setup the logger first to catch all errors
            ILogger logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Debug("Init main");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                //NLog: catch setup errors
                logger.Error(e, "Program stopped because of exception");
                throw;
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseNLog()
                .UseStartup<Startup>();
    }
}
