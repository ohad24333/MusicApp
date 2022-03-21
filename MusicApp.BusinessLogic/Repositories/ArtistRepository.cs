using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicApp.BusinessLogic
{
    public class ArtistRepository : IDisposable , IArtistRepository
    {

        private MusicAppDBContext _context;

        public static event Action<string> MessegeEvent;
        public static event Action<Artist> ArtistsAddedEvent;

        public ArtistRepository()
        {
            _context = new MusicAppDBContext();
        }
        public async void AddToDataBase(Artist artist)
        {
            string msg = "";
            if (!Regexes.NameRegex.IsMatch(artist.LastName))
            {
                msg += "First Name Shoulde Be Only Letters 2-10 Charachters";
            }
            if (!Regexes.NameRegex.IsMatch(artist.FirstName))
            {
                msg += "Last Name Shoulde Be Only Letters 2-10 Charachters";
            }
            if (msg != "")
            {
                MessegeEvent(msg);
                return;
            }
            else
            {
                try
                {
                    using (var db = new MusicAppDBContext())
                    {
                        var query = await db.Artists.AddAsync(artist);
                        db.SaveChanges();
                    }
                    ArtistsAddedEvent(artist);
                }
                catch (Exception e )
                {

                    MessegeEvent(e.Message);
                }
              
            }


        }
        public Artist SearchArtist(int id)
        {
            try
            {
                if (_context.Artists.Any(a => a.Id == id))
                {
                    Artist artist = _context.Artists.Single(a => a.Id == id);
                    return artist;
                }
                else return null;
            }
            catch (Exception e)
            {

                MessegeEvent(e.Message);
                return null;
            }
          

        }
        public List<Artist> SearchArtists(string txtSearchInsert)
        {
            try
            {
                if (_context.Artists.Any(a => a.StageName.ToLower().StartsWith(txtSearchInsert.ToLower())))
                {
                    var query1 = _context.Artists.Where(a => a.StageName.ToLower().StartsWith(txtSearchInsert.ToLower())).Select(a => a);
                    List<Artist> artists = query1.ToList();
                    return artists;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }
          

        }
        public void UpdateToDataBase(Artist artist)
        {
            try
            {
                _context.Update(artist);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
            }
          

        }
        public Coutry GetArtistCoutry(Artist artist)
        {
            try
            {
                return _context.Coutries.Single(c =>
              c.Artists.Single(a => a.Id == artist.Id).Coutry.Id == c.Id);
            }
            catch (Exception e)
            {
                MessegeEvent(e.Message);
                return null;
            }
          

        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
