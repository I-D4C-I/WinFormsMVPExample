using System.ComponentModel.DataAnnotations;

namespace WinFormsWPFExample.Models
{
    internal class PetModel
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "Необходимо имя питомца")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя питомца должно содержать от 2 до 50 символов")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Необходимо тип питомца")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Тип питомца должно содержать от 2 до 50 символов")]
        public string Type { get; set; } = null!;
        [Required(ErrorMessage = "Необходим цвет питомца")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Цвет питомца должно содержать от 2 до 50 символов")] 
        public string Color { get; set; } = null!;
    }
}