using BeautySalon.Entities.WeeklySchedules;
using BeautySalon.Services.WeeklySchedules.Contracts.Dtos;

namespace BeautySalon.Test.Tool.Entities.WeeklySchedules;
public class EditWeeklyScheduleDtoBuilder
{
    private readonly EditWeeklyScheduleDto _dto;
    public EditWeeklyScheduleDtoBuilder()
    {
        _dto = new EditWeeklyScheduleDto()
        {
            DayOfWeek = DayWeek.Monday,
            StartTime = new TimeOnly(8,10),
            EndTime = new TimeOnly(10,1),
            IsActive = true,
        };
    }

    public EditWeeklyScheduleDtoBuilder WithId(int id)
    {
        _dto.Id = id;
        return this;
    }

    public EditWeeklyScheduleDtoBuilder WithStartTime(TimeOnly time)
    {
        _dto.StartTime = time;
        return this;
    }

    public EditWeeklyScheduleDtoBuilder WithEndTime(TimeOnly time)
    {
        _dto.EndTime = time;
        return this;
    }

    public EditWeeklyScheduleDtoBuilder WithDayOfWeek(DayWeek day)
    {
        _dto.DayOfWeek = day;
        return this;
    }

    public EditWeeklyScheduleDtoBuilder WithIsActive()
    {
        _dto.IsActive = true;
        return this;
    }

    public EditWeeklyScheduleDto Build()
    {
        return _dto;
    }
}
