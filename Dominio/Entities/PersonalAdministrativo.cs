using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class PersonalAdministrativo{

        [Key]
        public int IdNroDeDocumento { get; set; }
        public string ? TipoDeDocumento { get; set; }
        public int Taller_Id { get; set; }
        public Taller ? Talleres { get; set; }
        public int Persona { get; set; }
        public Persona ? Personas { get; set; } 
        public string ? Puesto { get; set; }
        public string ? DescripcionDelPuesto { get; set; }
        public int AñosDeExperiencia { get; set; }
        public int NroRefereciaPersonal { get; set; }
        public DateTime FechaDeContratacion { get; set; }
        public int Salario { get; set; }
        public string ? InformacionAdicional { get; set; }


        
    }
