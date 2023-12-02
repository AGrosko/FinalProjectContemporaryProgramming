using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IFavTeamContextDOA
    {

        List<FavTeam> GetAllInfo();
        FavTeam GetInfo(int id);
        FavTeam RemoveInfoById(int id);

        int? UpdateInfo(FavTeam info);
        int? Add(FavTeam info);

    }
}
