using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneApp.Models
{
    public class Phone
    {
        
        public int iD { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Please enter the phone Brand with less than 50 characters")]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Phone Type")]
        [StringLength(20, ErrorMessage = "Please enter a phone name with less than 50 characters")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Battery Life")]
        public decimal batteryLife { get; set; }

        [Display(Name = "Launch Date")]
        public int LaunchDate { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public decimal phoneWeight { get; set; }

        [Required]
        [Display(Name = "OS")]
        public string phoneOS { get; set; }

        [Required]
        [Display(Name = "CPU")]
        public string phoneCPU { get; set; }

        [Display(Name = "Display")]
        public string phoneDisplay { get; set; }

        [Range(0, 5)]
        [Display(Name = "Consumer Rating")]
        public decimal phoneRating { get; set; }

        [Display(Name = "Image")]
        public string phoneImage { get; set; }
    }
}
