namespace BeautySalon.Services.WeeklySchedules.Contracts.Dtos;
public class GetDayScheduleDto
{
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public bool IsActive { get; set; }
}
