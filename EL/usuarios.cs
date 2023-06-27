using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EL
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int IdUsuarios { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nombredelusuario { get; set; }
        [MaxLength(200)]
        [Required]
        public string Correodelusuario { get; set; }
        [MaxLength(50)]
        [Required]
        public string Usuario { get; set; }
        [Required]
        public byte[] contraseña { get; set; }
        [Required]
        public bool Bloqueado { get; set; }
        [Required]
        public byte IntentosFallidos { get; set; }
        public short? IdRol { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public int IdUsuarioRegistra { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public int? IdUsuarioActualiza { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public Usuarios()
        {
            Nombredelusuario = string.Empty;
            Correodelusuario = string.Empty;
            Usuario = string.Empty;
            contraseña = UTF8Encoding.UTF8.GetBytes(string.Empty);
        }
    }
}
