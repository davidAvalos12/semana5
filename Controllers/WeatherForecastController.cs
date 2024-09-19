using Microsoft.AspNetCore.Mvc;

namespace WebApiSemana4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        /*
        [HttpGet ("DevolverSuma/{Numero1}/{Numero2}")]
        public int DevolverSuma (int Numero1, int Numero2)
        {
            int numero;
            numero = 10;
            string saludo = "Hola Mundo";
            bool existe = true;
            double flotante = 15.5;
            DateTime hoy = DateTime.Now;
            return Numero1 + Numero2;
            
        }
        [HttpGet("DevolverSaludo/{Nombre}")]
        public string DevolverSaludo(string Nombre)
        {
            return "Hola " + Nombre;

        }
        */

        [HttpGet("DevolverValor")]
        public int  DevolverValor()
        {
            int num1 = 8;
            int num2 = 5;
            int num3 = num1 - num2;
            num2 = num1 * num3;
            num3 = num2 + num1 * num2;
            num1 = num3 / num1;
            num2 = num1 % num2;
            return num2;
        }

        [HttpGet("DevolverSaludo")]
        public string DevolverSaludo()
        {
            string variable1 = "pedro";
            string variable2 = "juan";
            string variable3 = variable1 + variable2;
            int num1 = 7;
            string variable4 = variable3 + num1;
            string mensaje = "Hola " + variable4;
            return mensaje;
        }

        [HttpGet("DevolverMayor/{num1}/{num2}")]
        public string DevolverMayor(int num1, int num2)
        {

            if (num1 > num2)
            {
                return "el mayor es " + num1.ToString();
            }
            else
            {
                return "el mayor es " + num2.ToString();
            }
        }
            [HttpGet("DevolverEstado/{edad}/{nombre}")]
            public string DevolverEstado(int edad, string nombre)
            {
                string mensaje = "";
                if (edad>=18)
                {
                    mensaje = "Señor " + nombre + " es mayor de edad";
                }
                else
                {
                    mensaje = "Señor " + nombre + " es menor de edad";

                }

                return mensaje;
            }

        /*area de rectangulo*/
        [HttpGet("CalcularArea/{largo}/{ancho}")]
        public string CalcularArea(int largo, int ancho)
        {
            int area = largo * ancho;
            string mensaje = " El area del rectángulo cuya base tiene " + ancho +
                " y altura tiene " + largo + " es " + area;

            return mensaje;
        }


        /*calcular edad*/
        [HttpGet("CalcularEdad/{aNac}/{nombre}")]
        public string CalcularEdad(int aNac,string nombre)
        {
            int aActual = DateTime.Now.Year; // Obtener el año actual
            int edad = aActual - aNac;
            string mensaje = "Sr(a) " + nombre + 
                             " su edad es " + edad + " años";
            return mensaje;
        }

        /*generacion Z*/
        [HttpGet("CalcularGeneracion/{aNac}")]
        public string CalcularGeneracion(int aNac)
        {
            int aActual = DateTime.Now.Year; // Obtener el año actual
            int edad = aActual - aNac;
            string mensaje;
            if (edad >= 18 && edad <= 20)
            {
              mensaje=  "Usted es de la generación z";
            }
            else
            {
                mensaje = "Usted NO es de la generación z";
            }
            return mensaje;
        }

        /*creacion de objetos de la clase alumno*/
        [HttpGet("DevolverAlumno")]
        public int DevolverAlumno()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "71427872", new DateTime(2000,1,29) );
            return Alumno2.DevolverEdad();
        }
        
        
    }
}
