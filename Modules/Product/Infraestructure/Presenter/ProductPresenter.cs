using UyariSoftBk.Configuration.Shared;
using UyariSoftBk.Model.Dtos.Attedance;
using UyariSoftBk.Model.Dtos.Event;
using UyariSoftBk.Model.Dtos.Participant;
using UyariSoftBk.Model.Dtos.Teacher;
using UyariSoftBk.Modules.Event.Application.Port;
using UyariSoftBk.Modules.Product.Application.Port;

namespace UyariSoftBk.Modules.Product.Infraestructure.Presenter;

public class ProductPresenter : BasePresenter<object>, IProductOutPort
{
    public void GetAllAsync(IEnumerable<AttendanceDto> data)
    {
        Success(data);
    }

    public void GetById(AttendanceDto data)
    {
        Success(data);
    }

    public void TakeAttendance(ParticipantDataDto data)
    {
        Success(data);
    }
}