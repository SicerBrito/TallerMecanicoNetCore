using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Login{
        
        [Key]
        public int IdLogin { get; set; }
        public string ? Apodo { get; set; }
        public string ? Email { get; set; }
        public string ? Password { get; set; }
        public string ? TokenPassword { get; set; }
        public string ? NombreRol { get; set; }
        public string ? DescripcionRol { get; set; }
        public int Persona_Id { get; set; }
        public Persona ? Personas { get; set; }
        public string ? ImagenURL { get; set; }
        public DateTime Created_at { get; set; }
        
    }
