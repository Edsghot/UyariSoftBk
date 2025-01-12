using UyariSoftBk.Model.Dtos.Attedance;

namespace UyariSoftBk.Model.Dtos.Student;

public record StudentDto
{
    public int? IdStudent { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Mail { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public bool Gender { get; set; }
    public string Dni { get; set; } = string.Empty;

    public ICollection<AttendanceDto>? Attendances { get; set; } = new List<AttendanceDto>();

}