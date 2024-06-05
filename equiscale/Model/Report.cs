using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace equiscale.Model
{
    public class Report
    {
        [Key]
        public int SlipNo { get; set; }

        [Required]
        public string VehicleRegnNo { get; set; }

      
        public string VehicleType { get; set; }
   
        public string Supplier { get; set; }

        public string Customer { get; set; }
   
        public string Material { get; set; }
        public string Remarks { get; set; }
        public decimal Charges { get; set; }
        
        public string TareDate { get; set; }
        public string TareTime { get; set; }
       
        public string GrossDate { get; set; }
        public string GrossTime { get; set; }
        public int? TareWeight { get; set; }
        public int? GrossWeight { get; set; }
        public int? NetWeight { get; set; }

        public string LatestDate { get; set; }
        public string WeightType { get; set; }



    }
}
