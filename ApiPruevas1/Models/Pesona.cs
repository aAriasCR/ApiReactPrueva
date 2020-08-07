using ApiPruevas1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ApiPruevas1.Models
{
    public class Persona
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public int Edad { set; get; }
        public DateTime Fecha { set; get; }
    }

    public static class listaPersonas
    {
        public static List<Persona> personaList = new List<Persona>();

        public static void addElement(Persona persona) {


            persona.Id = personaList.Count > 0 ? personaList.Last().Id + 1 : 1;
            personaList.Add(persona);
        }

        public static Persona GetElement(int id)
        {
            return personaList.Where(x => x.Id == id).SingleOrDefault();
        }

        public static List<Persona> GetAllElements() {
            return personaList;
        }

        public static void UpdateElement(Persona persona)
        {
            foreach (Persona per in personaList.Where(x => x.Id == persona.Id)) { 
                per.Id = persona.Id;
                per.Nombre = persona.Nombre;
                per.Fecha = persona.Fecha;
                per.Edad = persona.Edad;
            }
        }

        public static void RemoveElement(int id)
        {
            personaList.RemoveAll(x => x.Id == id);
        }


    }
}
