using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Cliente{

        [Key]
        public int IdNroDeDocumento { get; set; }
        public string ? TipoDeDocumento { get; set; }
        public string ? TipoDeCliente { get; set; }
        public int Persona_Id { get; set; }
        public Persona ? Personas { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string ? NivelDeConfianza { get; set; }
        public string ? InformacionAdicional { get; set; }
        public ICollection<Historial> ? Historiales{ get; set; }
        public ICollection<FacturaEntregaVehiculo> ? FacturasDeEntrega{ get; set; }
        public ICollection<FacturaRevision> ? FacturasDeRevision{ get; set; }
        public ICollection<Vehiculo> ? Vehiculos { get; set; }
        public ICollection<FacturaVenta> ? FacturasDeVenta { get; set; }
        
    }
