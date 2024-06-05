using System.ComponentModel.DataAnnotations;

namespace equiscale.Model
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        public string ComPort { get; set; }
        public int BaudeRate { get; set; }
    }
}
