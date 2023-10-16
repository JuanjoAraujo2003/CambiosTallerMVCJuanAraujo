using System.ComponentModel.DataAnnotations;

namespace CambiosTallerMVCJuanAraujo.Models
{
    public class Burger
    {
        public int Id { get; set; }

        [Required]
        public String? Name { get; set; }
        public bool WithCheese { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
    }
}
