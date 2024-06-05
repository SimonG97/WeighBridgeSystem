using System.ComponentModel.DataAnnotations;

namespace equiscale.Model
{
    public class HouseKeeping
    {
        [Key]
        public int Id { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int TelephoneNo { get; set; }

    }
}
