using FinalProject.Interfaces;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class FavSongsContextDOA : IFavSongsContextDOA
    {

        private FavSongContext _context;

        public FavSongsContextDOA(FavSongContext context)
        {
            _context = context;

        }

        public int? Add(FavSong info)
        {
            var infos = _context.FavSongs.Where(x => x.name.Equals(info.name)).FirstOrDefault();

            if (infos != null) { return null; }
            try
            {
                _context.FavSongs.Add(info);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex) { return 0; }

        }

        public List<FavSong> GetAllInfo()
        {
            return _context.FavSongs.ToList();
        }

        public FavSong GetInfo(int id)
        {
            return _context.FavSongs.Where(x => x.iD.Equals(id)).FirstOrDefault();
        }

        public FavSong? RemoveInfoById(int id)
        {
            var info = this.GetInfo(id);
            if (info == null) { return null; }
            try
            {
                _context.FavSongs.Remove(info);
                _context.SaveChanges();
                return info;

            }
            catch (Exception ex) { return null; }
        }

        public int? UpdateInfo(FavSong info)
        {
            var infoToUpdate = this.GetInfo(info.iD);

            if (infoToUpdate == null) { return null; }


            infoToUpdate.name = info.name;
            infoToUpdate.artist = info.artist;
            infoToUpdate.song = info.song;
            infoToUpdate.genre = info.genre;
            try
            {
                _context.FavSongs.Update(infoToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex) { return 0; }

        }

    }
}
