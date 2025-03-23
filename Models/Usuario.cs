using System.ComponentModel.DataAnnotations;

namespace API_Quick_Response.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(50)]
        public string NombreUsuario { get; set; }

        [Required]
        public string ContraseñaHash { get; set; } // Aquí guardaremos la contraseña encriptada

        public string Rol { get; set; } = "Residente";

        public bool EstadoPago { get; set; } // true = Pagó, false = No ha pagado
    }
}