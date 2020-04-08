using System;
using System.Collections.Generic;

namespace Proyecto_ASP_NET_CORE.Models
{
    public class Escuela : ObjetoEscuelaBase
    {

        public int AñoDeCreacion { get; set; }

        //Propiedades es decir los get y los set
        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public string Dirección { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        /*
                public Escuela(string nombre, int año){
                    this.nombre = nombre;
                    AñoDeCreacion = año;
                }
        */

        //Constructor de la manera mas corta por tuplas(lenguajes funcionales)
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);


        public Escuela(string nombre, int año,
                    TiposEscuela tipos,
                    string pais = "", string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public Escuela()
        {
            
        }


        //Sobreescribir
        public override string ToString()
        {
            //return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";

        }

    }
}