using System;
using System.ComponentModel.DataAnnotations;

namespace equiscale.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string UserID { get; set; }
       
        public string Password { get; set; }
       
        public string validityDate { get; set; }
    }
}
