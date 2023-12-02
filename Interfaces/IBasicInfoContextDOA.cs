using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IBasicInfoContextDOA
    {


        List<BasicInfo> GetAllInfo();
        BasicInfo GetInfo(int id);
       BasicInfo RemoveInfoById(int id);

        int? UpdateInfo(BasicInfo info);
        int? Add(BasicInfo info);
    }
}
