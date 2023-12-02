using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IFavSongsContextDOA
    {

        List<FavSong> GetAllInfo();
        FavSong GetInfo(int id);
        FavSong RemoveInfoById(int id);

        int? UpdateInfo(FavSong info);
        int? Add(FavSong info);


    }
}
