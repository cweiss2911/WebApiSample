using Microsoft.AspNetCore.Hosting;
using System;
namespace CoreSample
{
    class CoreProgram
    {

        static void Main()
        {
            var webHost = new WebHostBuilder()
              .UseKestrel()
              .UseStartup<Startup>()
              .Build();


            Console.WriteLine("http://localhost:9000/api/Values/fire");
            Console.WriteLine("http://localhost:9000/api/Values/fire2");
            webHost.Run(); //RunAsync();


        }
    }
}

