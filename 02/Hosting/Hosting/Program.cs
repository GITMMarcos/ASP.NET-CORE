using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * O Host é sempre criado na classe Program.cs no método Main(String[] args),
             * inclusive em aplicações Web. No .NET CORE sempre haverá um ponto de execução para a
             * aplicação e esse ponto é o método Main da classe Program.cs
             */
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .Configure(app => {
                    app.Run(context => context.Response.WriteAsync("<h1>Hello Word!</h1>"));
                })
                .Build();

            host.Run();
        }
    }
}
