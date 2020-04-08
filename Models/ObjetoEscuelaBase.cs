using System;

namespace Proyecto_ASP_NET_CORE.Models
{
    //abstract que no pueden crear instancias pero si exite la herencia
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
           
        }

        //ToString() representar el contenido de un objeto
        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}