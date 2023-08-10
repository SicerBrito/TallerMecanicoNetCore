using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Horario{

        [Key]
        public int IdHorario { get; set; }
        public int Taller_Id { get; set; }
        public Taller ? Talleres { get; set; }
        public string ? Dias { get; set; }
        public DateTime HorarioEntrada { get; set; }
        public DateTime HorarioSalida { get; set; }


    }
