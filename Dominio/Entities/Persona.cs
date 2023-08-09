using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Persona{
        
        [Key]
        public int IdNroDeDocumento { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public int Edad { get; set; }
        public string ? TipoDeDocumento { get; set; }
        public int Contactos_Id { get; set; }
        public Contacto ? Contactos { get; set; }
        public string ? Genero { get; set; }
        public string ? Direccion { get; set; }
        public string ? Ciudad { get; set; }
        public int NroCodigoPostal { get; set; }
        public string ? Departamento { get; set; }
        public string ? Zona { get; set; }
        public ICollection<Login> ? Logins { get; set; } 
        public ICollection<PersonalAdministrativo> ? PersonasAdministrativas { get; set; }
        public ICollection<Cliente> ? Clientes { get; set; }
        public ICollection<Proveedor> ? Proveedores { get; set; }
        public ICollection<Mecanico> ? Mecanicos { get; set; }

    }
