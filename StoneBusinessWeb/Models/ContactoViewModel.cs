using System.ComponentModel.DataAnnotations;

namespace StoneBusinessWeb.Models
{
    public class ContactoViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [Display(Name = "Nombre completo")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingresa un correo válido.")]
        [Display(Name = "Correo electrónico")]
        public string Correo { get; set; } = string.Empty;

        [Display(Name = "Teléfono")]
        public string? Telefono { get; set; }

        [Display(Name = "Servicio de interés")]
        public string? Servicio { get; set; } 
        public string Mensaje { get; set; } = string.Empty;
    }
}