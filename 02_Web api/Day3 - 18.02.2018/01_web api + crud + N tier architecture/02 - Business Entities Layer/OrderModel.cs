using System;
using System.ComponentModel.DataAnnotations;

namespace JohnBryce
{
    public class OrderModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Customer ID must be 5 chars.")]
        public string custID { get; set; }

        [Required]
        public DateTime? date { get; set; }

        [StringLength(40, ErrorMessage = "Ship name cant exceeds 40 chars.")]
        public string ship { get; set; }
    }
}

//[Required]
//[StringLength]
//[RegularExpression]
//[Range]
//[Compare]
//[CustomValidation]

