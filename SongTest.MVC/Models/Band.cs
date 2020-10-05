using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SongTest.MVC.Models
{
    public class Band
    {
        [Key]
        public int BandId { get; set; }
       
        public Guid? UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Members { get; set; }
        [Display(Name = "Years Active")]
        public string YearsActive { get; set; }
        public int NumberOfAlbums { get; set; }
    }
}