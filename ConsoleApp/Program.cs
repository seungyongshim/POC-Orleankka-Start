using System;
using System.Net;
using System.Threading.Tasks;
using Orleankka;
using Orleans.Hosting;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = await new SiloHostBuilder()
                .UseDevelopmentClustering(o =>
                {
                    o.PrimarySiloEndpoint = new IPEndPoint
                })
        }
    }
}
