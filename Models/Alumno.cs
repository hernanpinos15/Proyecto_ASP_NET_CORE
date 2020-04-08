using System;
using System.Collections.Generic;

namespace Proyecto_ASP_NET_CORE.Models
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();

    }  
}