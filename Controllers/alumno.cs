using Microsoft.AspNetCore.Mvc;

namespace WebApiSemana4.Controllers
{
    public class Alumno
    {
        /*creando propiedades*/
        string Nombre;
        string Apellido;
        string Dni;
        DateTime fechaNacimiento;


        public Alumno()
        {
            Nombre = string.Empty; // cadena vacio = ""
            Apellido = string.Empty;
            Dni = string.Empty;
            fechaNacimiento = DateTime.Now; //fecha del dia de hoy
        }

        //constructor con parametros
        public Alumno(string pNombre, string pApellido, string pDni)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Dni = pDni;
        }
        public Alumno(string pNombre, string pApellido, string pDni, DateTime pfechaNacimiento)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Dni = pDni;
            fechaNacimiento = pfechaNacimiento;
        }

        public string DevolverNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public string DevolverDni()
        {
            return Nombre + " su dni es: " + Dni;
        }

        public int DevolverEdad()
        {
            return DateTime.Now.Year -  fechaNacimiento.Year;
        }

    } 
}
