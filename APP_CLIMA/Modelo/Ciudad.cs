using Newtonsoft.Json;
using System.Collections.Generic;

namespace APP_CLIMA.Modelo
{
    public class Ciudad
    {
        public string Name { get; set; }
        public Sys Sys { get; set; } // Contiene información como el país
    }

    public class Sys
    {
        public string Country { get; set; }
    }

    public class CiudadInfo
    {
        [JsonProperty("name")]
        public string Nombre { get; set; }

        [JsonProperty("coord")]
        public Coordenadas Coord { get; set; }

        [JsonProperty("weather")]
        public List<WeatherInfo> Weather { get; set; }

        [JsonProperty("main")]
        public MainInfo Main { get; set; }

        [JsonProperty("wind")]
        public WindInfo Wind { get; set; }

        [JsonProperty("clouds")]
        public CloudsInfo Clouds { get; set; }

        [JsonProperty("sys")]
        public SysInfo Sys { get; set; }

        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cod")]
        public int Cod { get; set; }
    }

    public class Coordenadas
    {
        [JsonProperty("lon")]
        public double Longitud { get; set; }

        [JsonProperty("lat")]
        public double Latitud { get; set; }
    }

    public class WeatherInfo
    {
        [JsonProperty("main")]
        public string Condicion { get; set; }

        [JsonProperty("description")]
        public string Descripcion { get; set; }

        [JsonProperty("icon")]
        public string Icono { get; set; }
    }

    public class MainInfo
    {
        [JsonProperty("temp")]
        public double Temperatura { get; set; }

        [JsonProperty("feels_like")]
        public double SensacionTermica { get; set; }

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax { get; set; }

        [JsonProperty("pressure")]
        public int Presion { get; set; }

        [JsonProperty("humidity")]
        public int Humedad { get; set; }
    }

    public class WindInfo
    {
        [JsonProperty("speed")]
        public double Velocidad { get; set; }

        [JsonProperty("deg")]
        public int Direccion { get; set; }

        [JsonProperty("gust")]
        public double Racha { get; set; }
    }

    public class CloudsInfo
    {
        [JsonProperty("all")]
        public int Nubosidad { get; set; }
    }

    public class SysInfo
    {
        [JsonProperty("country")]
        public string Pais { get; set; }

        [JsonProperty("sunrise")]
        public long Amanecer { get; set; }

        [JsonProperty("sunset")]
        public long Atardecer { get; set; }
    }
}
