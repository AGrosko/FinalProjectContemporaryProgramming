using FinalProject.Interfaces;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class BasicInfoContextDOA : IBasicInfoContextDOA
    {
       private BasicInfoContext _context;

        public BasicInfoContextDOA(BasicInfoContext context) {
        _context = context;
        
        }

        public int? Add(BasicInfo info)
        {
            var infos = _context.BasicInfos.Where(x => x.name.Equals(info.name)).FirstOrDefault();

            if (infos != null) { return null; }
            try
            {
                _context.BasicInfos.Add(info);
                _context.SaveChanges();
                return 1;
            }catch (Exception ex) { return 0; }

        }

        public List<BasicInfo> GetAllInfo()
        {
          return   _context.BasicInfos.ToList();
        }

        public BasicInfo GetInfo(int id)
        {
            return _context.BasicInfos.Where(x => x.id.Equals(id)).FirstOrDefault();
        }

        public BasicInfo? RemoveInfoById(int id)
        {
            var info = this.GetInfo(id);
            if (info == null) { return null; }
            try
            {
                _context.BasicInfos.Remove(info);
                _context.SaveChanges();
                return info;

            }catch (Exception ex) { return null; }
        }

        public int? UpdateInfo(BasicInfo info)
        {
            var infoToUpdate = this.GetInfo(info.id);

            if (infoToUpdate == null) { return null; }


            infoToUpdate.name = info.name;
            infoToUpdate.collegeProgram = info.collegeProgram;
            infoToUpdate.yearInProgram = info.yearInProgram;
            infoToUpdate.birthDate = info.birthDate;
            try
            {
                _context.BasicInfos.Update(infoToUpdate);
                _context.SaveChanges();
                return 1;
            }catch (Exception ex) { return 0; }

        }



    }
}
