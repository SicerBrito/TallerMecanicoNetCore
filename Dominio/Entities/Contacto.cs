using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Contacto{

        [Key]
        public int IdContacto { get; set; }
        public int NroTelefono { get; set; }
        public string ? Email { get; set; }
        public int Taller_Id { get; set; }
        public Taller ? Talleres { get; set; }
        public int Persona_Id { get; set; }
        public Persona ? Personas { get; set; }
        
    }
