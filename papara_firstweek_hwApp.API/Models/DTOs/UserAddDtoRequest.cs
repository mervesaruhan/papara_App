using System.ComponentModel.DataAnnotations;

namespace papara_firstweek_hwApp.API.Models.DTOs
{
    public class UserAddDtoRequest
    {

        [StringLength(10, MinimumLength = 3, ErrorMessage = "Kullanıcı  adı 3 ile 10 karakter arasında olmalıdır.")]
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string Name { get; set; } = null!;

        
        [Required(ErrorMessage = "Kullanıcı soyadı adı boş geçilemez!")]
        public string Surname { get; set; } = null!;

        [Range(10, 64, ErrorMessage = "Yaş aralığı 18 ile 64 arasında olmalıdır.")]
        [Required(ErrorMessage = "Kullanıcı yaşı boş geçilemez!")]
        public int? Age { get; set; }
    }
}
