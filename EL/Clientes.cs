using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Formularios")]
    public class Clientes
    {
        [Key]
        public int IDclientes { get; set; }
        [Required]
        [MaxLength(200)]
        public string nombreCliente { get; set; }
        [Required]
        [MaxLength(10)]
        public string Numero { get; set; }
        [Required]
        [MaxLength(200)]
        public bool activo  { get; set;}
        [Required]
        public int IdUsuarioRegistra { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public Clientes()
        {
            nombreCliente = "";
        }

    }
}
