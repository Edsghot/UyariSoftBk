
using UyariSoftBk.Model.Dtos.Attedance;
using UyariSoftBk.Model.Dtos.Event;

namespace UyariSoftBk.Modules.Product.Application.Port;

public interface IProductInputPort
{
    Task GetAllAsync();
    Task GetById(int id);
    Task AddParticipant(InsertParticipantDto data);
    Task TakeAttendance(InsertAttendanceDto data);
}