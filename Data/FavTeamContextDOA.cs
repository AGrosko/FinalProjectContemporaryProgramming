using FinalProject.Interfaces;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class FavTeamContextDOA : IFavTeamContextDOA
    {

        private FavTeamContext _context;

        public FavTeamContextDOA(FavTeamContext context)
        {
            _context = context;

        }

        public int? Add(FavTeam team)
        {
            var infos = _context.FavTeams.Where(x => x.name.Equals(team.name)).FirstOrDefault();

            if (infos != null) { return null; }
            try
            {
                _context.FavTeams.Add(team);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex) { return 0; }

        }

        public List<FavTeam> GetAllInfo()
        {
            
            return _context.FavTeams.ToList();
        }

        public FavTeam GetInfo(int id)
        {
            return _context.FavTeams.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public FavTeam? RemoveInfoById(int id)
        {
            var team = this.GetInfo(id);
            if (team == null) { return null; }
            try
            {
                _context.FavTeams.Remove(team);
                _context.SaveChanges();
                return team;

            }
            catch (Exception ex) { return null; }
        }

        public int? UpdateInfo(FavTeam info)
        {
            var infoToUpdate = this.GetInfo(info.Id);

            if (infoToUpdate == null) { return null; }


            infoToUpdate.name = info.name;
            infoToUpdate.football = info.football;
            infoToUpdate.basketball = info.basketball;
            infoToUpdate.collegefootball = info.collegefootball;
            try
            {
                _context.FavTeams.Update(infoToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex) { return 0; }

        }



    }
}
