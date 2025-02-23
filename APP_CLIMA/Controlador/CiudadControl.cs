using APP_CLIMA.Modelo;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace APP_CLIMA.Controlador
{
    public class CiudadControl
    {
        private HttpClient httpClient;
        private string ID = "5dda6344de1bbebfba492e31d1774174";

        public CiudadControl()
        {
            httpClient = new HttpClient();
        }

        public async Task<CiudadInfo> GetInfoCiudad(string c)
        {
            try
            {
                if (c == null && c == "[--------- SELECCIONE ---------]")
                {
                    return null;
                }

                string url = "https://api.openweathermap.org/data/2.5/weather?q=" + c + "&appid=" + ID;

                HttpResponseMessage respuesta = await httpClient.GetAsync(url);

                respuesta.EnsureSuccessStatusCode();

                string respuestaJson = await respuesta.Content.ReadAsStringAsync();

                Console.WriteLine(respuestaJson); // Para depuración

                return JsonConvert.DeserializeObject<CiudadInfo>(respuestaJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public List<string> GetCiudadesDisponibles()
        {
            return new List<string> { "[--------- SELECCIONE ---------]", "Carazo", "Managua", "León", "Granada" }; // Lista de respaldo
        }


    }
}
