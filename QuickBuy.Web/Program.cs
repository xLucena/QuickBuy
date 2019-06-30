using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace QuickBuy.Web
{
    public class Program
    {
        //METODO MAIN (PRINCIPAL), toda vez que eh executado eh executado o MAIN por que ele eh o principal.
        public static void Main(string[] args)
        {
            //Criando um hospedeiro, recurso utilizado pra hospedar o APP
            CreateWebHostBuilder(args).Build().Run();
        }
        //Retornando essa INTERface
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
