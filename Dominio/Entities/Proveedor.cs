using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Proveedor{
        
        [Key]
        public int IdNroDeDocumento { get; set; }
        public string ? TipoDeDocumento { get; set; }
        public int Persona_Id { get; set; }
        public Persona ? Personas { get; set; }
        public string ? TipoDeProveedor { get; set; }
        public string ? DescripcionDelTipo { get; set; }
        public double NroRUC { get; set; }
        public int AñosDeExperiencia { get; set; }
        public int NroRefereciaPersonal { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string ? ProductosYServicios { get; set; }
        public string ? Ubicacion { get; set; }
        public int NroCodigoPostal { get; set; }
        public string ? Departamento { get; set; }
        public string ? Zona { get; set; }
        public string ? InformacionFiscal { get; set; }
        public string ? InformacionAdicional { get; set; }
        public ICollection<Repuesto> ? Repuestos { get; set; }
        public ICollection<FacturaCompraRepuestos> ? FacturasDeCompraRepuestos { get; set; }
        public ICollection<InformacionFiscal> ? InformacionesFiscales { get; set; }
        
    }
