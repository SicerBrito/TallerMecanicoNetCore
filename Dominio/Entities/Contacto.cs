using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Contacto{
        [Key]
        public int IdContacto { get; set; }
        public int NroTelefono { get; set; }
        public string ? Email { get; set; }
        public ICollection<Persona> ? Personas { get; set; }
        public ICollection<FacturaEntregaVehiculo> ? FacturasDeEntrega{ get; set; }
        public ICollection<Taller> ? Talleres { get; set; }
        
    }
