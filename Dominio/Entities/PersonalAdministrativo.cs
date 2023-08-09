using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class PersonalAdministrativo{

        [Key]
        public int IdNroDeDocumento { get; set; }
        public string ? TipoDeDocumento { get; set; }
        
    }
