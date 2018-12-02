using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApp_ClasseDeInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    //Foi isolada a responsabilidade.
    //Toda aplicação Web posuirá uma classe Startup.cs com o método Configure(IApplicationBuilder app)
    internal class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Iniciando um hosting através da classe Startup.cs");
            });
        }
    }
}
