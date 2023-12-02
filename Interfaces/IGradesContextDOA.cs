using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IGradesContextDOA
    {


        List<Grades> GetAllInfo();
        Grades GetInfo(int id);
        Grades RemoveInfoById(int id);

        int? UpdateInfo(Grades info);
        int? Add(Grades info);
    }
}
