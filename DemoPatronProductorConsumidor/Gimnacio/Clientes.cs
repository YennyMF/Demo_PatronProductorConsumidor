using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Gimnacio
{
    public class Clientes
    {
      public int Id_gimnasio { get; set; }
        public string Nombre { get; set; }    
        public string CorreoElectronico { get; set; } 
        public string Telefono { get; set; }
    public DateTime FechaInauguracion { get; set; }

        public Clientes(int id, string nombre, string correo, string telefono)
        {
            Id_gimnasio = id;
            Nombre = nombre;
            CorreoElectronico = correo;
            Telefono = telefono;
            FechaInauguracion = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Id:{Id_gimnasio},Nombre:{Nombre},Correo:{CorreoElectronico},Telefono:{Telefono},Fecha:{FechaInauguracion}";
        }
    }
}
