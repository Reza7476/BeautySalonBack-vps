using BeautySalon.Entities.WeeklySchedules;

namespace BeautySalon.Test.Tool.Entities.WeeklySchedules;
public class WeeklyScheduleBuilder
{
    private readonly WeeklySchedule _schedule;

    public WeeklyScheduleBuilder()
    {
        _schedule = new WeeklySchedule()
        {
            DayOfWeek = DayWeek.Tuesday,
            IsActive = true,
            StartTime = new TimeOnly(8,1),
            EndTime = new TimeOnly(10,1),
        };
    }

    public WeeklyScheduleBuilder WithDay(DayWeek day)
    {
        _schedule.DayOfWeek = day;
        return this;
    }

    public WeeklyScheduleBuilder WithStartTime(TimeOnly time)
    {
        _schedule.StartTime = time;
        return this;
    }

    public WeeklyScheduleBuilder WithEndTime(TimeOnly time)
    {
        _schedule.EndTime = time;
        return this;
    }

    public WeeklyScheduleBuilder WithIsActive(bool active)
    {
        _schedule.IsActive = active;
        return this;
    }

    public WeeklySchedule Build()
    {
        return _schedule;
    }
}
