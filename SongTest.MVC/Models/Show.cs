using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SongTest.MVC.Models
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }
       
        public Guid? UserId { get; set; }
        [Required]
        [ForeignKey("Band")]
        
        [Display(Name = "Band Name ")]
        
        public int BandId { get; set; }
        [Required]
        public string Venue { get; set; }
        public string Location { get; set; }
        [Required]
        public DateTime Date { get; set; }
        /*[ForeignKey("Song")]
        [Display(Name = "Set List")]
        public int SongId { get; set; }*/

       
        public virtual Band Band { get; set; }
        /*public virtual Song Song { get; set; }*/

    }
}