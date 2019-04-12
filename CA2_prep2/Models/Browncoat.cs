using CA2_prep2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //For validation
using System.ComponentModel.DataAnnotations.Schema; //To generate ID
using System.Linq;
using System.Threading.Tasks;

namespace CA2_prep2.Models
{
    public class Browncoat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required]
        [Display(Name = "First name")]
        [RegularExpression(@"[A-Z,a-z,á, Á, ó, Ó, ú, Ú, í, Í, é, É]{2,50}", ErrorMessage = "Please enter a valid name")]
        public string FirstName { get; set; } = "";


        [Required (ErrorMessage ="This field is required")]
        [Display(Name = "Surname")]
        [RegularExpression(@"[A-Z,a-z,á, Á, ó, Ó, ú, Ú, í, Í, é, É,']{2,50}", ErrorMessage = "Please enter a valid name")]
        public string Surname { get; set; } = "";

        [Required(ErrorMessage = "Please enter a PPS Number")]
        [Display(Name = "PPSN")]
        [RegularExpression(@"\d{7}\w{1}", ErrorMessage = "Please enter a valid PPS")]
        public string PPSN { get; set; } = "";

        [Required]
        [Age]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Range (1, 10)]
        public int Number { get; set; }
    }
}
