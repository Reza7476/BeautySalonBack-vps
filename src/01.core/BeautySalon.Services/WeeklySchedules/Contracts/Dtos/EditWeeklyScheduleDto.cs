using BeautySalon.Entities.WeeklySchedules;

namespace BeautySalon.Services.WeeklySchedules.Contracts.Dtos;
public class EditWeeklyScheduleDto
{
    public DayWeek DayOfWeek { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; } 
    public bool IsActive { get; set; }
    public int Id { get; set; }
}
