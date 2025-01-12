using UyariSoftBk.Model.Dtos.Attedance;
using UyariSoftBk.Model.Dtos.Event;
using UyariSoftBk.Model.Dtos.Guest;
using UyariSoftBk.Model.Dtos.Student;
using Mapster;
using UyariSoftBk.Model.Dtos.Teacher;
using UyariSoftBk.Modules.Product.Domain.Entity;
using UyariSoftBk.Modules.Event.Domain.Entity;
using UyariSoftBk.Modules.Student.Domain.Entity;
using UyariSoftBk.Modules.Teacher.Domain.Entity;

namespace UyariSoftBk.Mapping;

public class MappingConfig
{
    public static void RegisterMappings()
    {
        TypeAdapterConfig<ProductEntity, AttendanceDto>.NewConfig();
        TypeAdapterConfig<ParticipantDto, StudentDto>.NewConfig();
        TypeAdapterConfig<ParticipantDto, TeacherDto>.NewConfig();
    }
}