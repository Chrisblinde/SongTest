using SongTest.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SongTest.MVC.DAL
{
    public class TestInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SongTestContext>
    {
        protected override void Seed (SongTestContext context)
        {
            var bands = new List<Band>
            {
                new Band{Name="Phish", Members="Trey, Mike, Page, Jon", YearsActive="37"},
                new Band{Name="Cova", Members="Abe, Nate, Rob, Blinde, Forrest", YearsActive="6"}
            };
            bands.ForEach(s => context.Bands.Add(s));
            context.SaveChanges();

            var shows = new List<Show>
            {
                new Show{ Venue="Deer Creek", Location="Noblesville", Date=DateTime.Parse("1999/07/23") }
              
            };
            shows.ForEach(s => context.Shows.Add(s));

            var songs = new List<Song>
            {
                new Song{ Name="Destiny Unbound", TimesSeen=int.Parse("1")}
            };
            songs.ForEach(s => context.Songs.Add(s));
            context.SaveChanges();


           
        }
    }
}

