using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Servicio{
        
        [Key]
        public int IdServicio { get; set; }
        public int Taller_Id { get; set; }
        public Taller ? Talleres { get; set; }
        public string ? NombreDelServicio { get; set; }
        public string ? DescripcionDelServicio { get; set; }


    }
