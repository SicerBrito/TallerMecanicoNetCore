using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class FacturaRevision{
        [Key]
        public int IdNroFacturaRevision { get; set; }
        public int Taller_Id { get; set; }
        public Taller ? Talleres { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Mecanico_Id { get; set; }
        public Mecanico ? Mecanicos { get; set; }
        public DateTime FechaRevision { get; set; }
        public string ? ResultadoRevision { get; set; }
        public string ? Descripcion { get; set; }
        public string ? ArreglosRecomendados { get; set; }
        public int Cliente_Id { get; set; }
        public Cliente ? Clientes { get; set; }
        public string ? FirmaAprobacion { get; set; }
        public ICollection<Pago> ? Pagos { get; set; }
        public ICollection<FacturaAutorizacion> ? FacturasDeAutorizacion { get; set; }

    }
