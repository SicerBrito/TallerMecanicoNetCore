using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Certificacion{

        [Key]
        public int IdCertificacion { get; set; }
        public int Taller_Id { get; set; }
        public Taller ? Talleres { get; set; }
        public int NroCertificacion { get; set; }
        public string ? NombreCertificacion { get; set; }
        public string ? OrganismoEmisor { get; set; }
        public DateTime FechaObtencion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string ? DetallesDeLaCertificacion { get; set; }
        public string ? URLDocumentoDeCertificacion { get; set; }
        public string ? EstadoCertificacion { get; set; }

    }
