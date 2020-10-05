using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SongTest.MVC.Models
{
    public class Song
    {

        
        public Guid? UserId { get; set; }
        [Required]
        [Key]
        public int SongId { get; set; }
        [ForeignKey("Band")]
        [Required]
        [Display(Name="Band Name ")]
        public int BandId { get; set; }
        [Required]
        [ForeignKey("Show")]
        public int ShowId { get; set; }
       // public string NameOfBand { get; set; }
        [Required]
        public string Name { get; set; }
        public int TimesSeen { get; set; }

        public virtual Band Band { get; set; }
        public virtual Show Show { get; set; }

    }
}