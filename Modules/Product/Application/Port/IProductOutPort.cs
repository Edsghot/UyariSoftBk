using UyariSoftBk.Configuration.Shared;
using UyariSoftBk.Model.Dtos.Attedance;
using UyariSoftBk.Model.Dtos.Event;
using UyariSoftBk.Model.Dtos.Participant;
using UyariSoftBk.Model.Dtos.Teacher;

namespace UyariSoftBk.Modules.Product.Application.Port;

public interface IProductOutPort : IBasePresenter<object>
{
    void GetAllAsync(IEnumerable<AttendanceDto> data);
    void GetById(AttendanceDto teacher);
    void TakeAttendance(ParticipantDataDto data);
}