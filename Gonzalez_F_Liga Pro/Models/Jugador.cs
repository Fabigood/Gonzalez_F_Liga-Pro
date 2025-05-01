using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Gonzalez_F_Liga_Pro.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Posicion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [MaxLength(50)]
        public string Nacionalidad { get; set; }

        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public virtual Equipo Equipo { get; set; }
    }
}
