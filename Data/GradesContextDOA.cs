using FinalProject.Interfaces;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class GradesContextDOA :IGradesContextDOA
    {

        private GradesContext _context;

        public GradesContextDOA(GradesContext context)
        {
            _context = context;

        }

        public int? Add(Grades info)
        {
            var infos = _context.Gradess.Where(x => x.Name.Equals(info.Name)).FirstOrDefault();

            if (infos != null) { return null; }
            try
            {
                _context.Gradess.Add(info);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex) { return 0; }

        }

        public List<Grades> GetAllInfo()
        {
            return _context.Gradess.ToList();
        }

        public Grades GetInfo(int id)
        {
            return _context.Gradess.Where(x => x.ID.Equals(id)).FirstOrDefault();
        }

        public Grades? RemoveInfoById(int id)
        {
            var info = this.GetInfo(id);
            if (info == null) { return null; }
            try
            {
                _context.Gradess.Remove(info);
                _context.SaveChanges();
                return info;

            }
            catch (Exception ex) { return null; }
        }

        public int? UpdateInfo(Grades info)
        {
            var infoToUpdate = this.GetInfo(info.ID);

            if (infoToUpdate == null) { return null; }


            infoToUpdate.Name = info.Name;
            infoToUpdate.mathGrade = info.mathGrade;
            infoToUpdate.scienceGrade = info.scienceGrade;
            infoToUpdate.englishGrade = info.englishGrade;
            try
            {
                _context.Gradess.Update(infoToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception ex) { return 0; }

        }



    }
}
