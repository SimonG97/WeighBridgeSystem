using System.ComponentModel.DataAnnotations;

namespace equiscale.Model
{
    public class InAppUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
