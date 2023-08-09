using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Mecanico{

        [Key]
        public int IdNroDeDocumento { get; set; }
        public string ? TipoDeDocumento { get; set; }
        public int Taller_Id { get; set; }
        public Taller ? Talleres { get; set; }
        public int Persona_Id { get; set; }
        public Persona ? Personas { get; set; }
        public string ? Especializacion { get; set; }
        public string ? DescripcionEspecializacion { get; set; }
        public int AñosDeExperiencia { get; set; }
        public int NroRefereciaPersonal { get; set; }
        public string ? NombresDelReferente { get; set; }
        public string ? ApellidosDelReferente { get; set; }
        public int CedulaDelReferente { get; set; }
        public string ? RelacionConElReferente { get; set; }
        public DateTime FechaDeContratacion { get; set; }
        public double Salario { get; set; }
        public string ? InformacionAdicional { get; set; }
        public ICollection<Historial> ? Historiales { get; set; }
        public ICollection<FacturaRevision> ? FacturasDeRevision { get; set; }

        
    }
