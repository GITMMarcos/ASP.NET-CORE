using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .Configure(app => {
                    app.Run(context => context.Response.WriteAsync("Hello Word!"));
                })
                .Build();

            host.Run();
        }
    }
}
