using Microsoft.Extensions.Configuration;
using System.IO;

namespace ChistesApi.Configuration
{
    public static class AppConfig
    {
        public static IConfiguration CargarConfiguracion()
        {
            var builder = new ConfigurationBuilder() //Proporciona medios para configs con Json entre otros.
                .SetBasePath(Directory.GetCurrentDirectory()) //  Establecemos la ruta a buscar.
                .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true); //agregamos archivo, debe existir la ruta, poder hacer cambios en ejecucion.

            return builder.Build(); //Finaliza la contruccion y devolvemos el objeto IConfiguration.
        }
    }
}