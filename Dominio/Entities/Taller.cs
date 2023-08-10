using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Taller{
        
        [Key]
        public int IdTaller { get; set; }
        public string ? NombreDelTaller { get; set; }
        public string ? URLImagenDelTaller { get; set; }
        public int Contactos_Id { get; set; }
        public Contacto ? Contactos { get; set; }
        public string ? Ubicacion { get; set; }
        public string ? Pais { get; set; }
        public string ? Ciudad { get; set; }
        public string ? Estado { get; set; }
        public int NroCodigoPostal { get; set; }
        public string ? Departamento { get; set; }
        public string ? Zona { get; set; }
        public string ? URLSitioWeb { get; set; }
        public string ? NombreDelGerente { get; set; }
        public string ? DatosAdicionales { get; set; }
        public ICollection<Repuesto> ? Repuestos { get; set; }
        public ICollection<Servicio> ? Servicios { get; set; }
        public ICollection<Especialidad> ? Especialidades { get; set; }
        public ICollection<Horario> ? Horarios { get; set; }
        public ICollection<Horario> ? Horarios { get; set; }
        public ICollection<Horario> ? Horarios { get; set; }
        public ICollection<Horario> ? Horarios { get; set; }
        public ICollection<Horario> ? Horarios { get; set; }
        public ICollection<Horario> ? Horarios { get; set; }
        
    }
