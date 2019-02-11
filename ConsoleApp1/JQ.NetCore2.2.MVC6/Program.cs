using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace JQ.NetCore2._2.MVC6
{
    /// <summary>
    /// .Net core integrate the Kestrel web server
    /// IIS can only play an role of Reverse Proxy
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>() //Startup class is the core class
                .Build();
    }
}
