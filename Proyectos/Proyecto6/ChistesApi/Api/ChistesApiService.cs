using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChistesApi.Api
{
    public class ChistesApiService
    {
        private readonly string _apiUrl;

        public ChistesApiService (string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        public async Task<string> ObtenerChisteApi()
        {
            using (HttpClient cliente = new HttpClient())
            {
                HttpResponseMessage response = await cliente.GetAsync(_apiUrl); // Hacemos la solicitud GET a la api
                response.EnsureSuccessStatusCode(); //Se verifica la respuesta si fue exitosa.

                string responseBody = await response.Content.ReadAsStringAsync(); // Leemos el contenido de la respuesta.
                var jsonDocument = JsonDocument.Parse(responseBody); // Parseamos el JSON.
                string chiste = jsonDocument.RootElement.GetProperty("value").GetString(); // Obtenemos el chiste almacenado en "value"
                
                return chiste;
            }
        }
    }
}