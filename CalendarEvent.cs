using System;

public class CalendarEvent
{
    public string Title { get; set; } = "";
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Description { get; set; } = "";
    public string Color { get; set; } = "#1976d2";
    public bool IsAllDay { get; set; }
}

public enum CalendarViewType
{
    Month,
    Week,
    Day
}
