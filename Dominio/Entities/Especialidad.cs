using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Especialidad{
        
        [Key]
        public int IdEspecialidad { get; set; }
        public int Taller_Id { get; set; }
        public Taller ? Talleres { get; set; }
        public string ? NombreEspecialidad { get; set; }

    }
