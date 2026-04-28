public class ServiceRequest
{
    public string RequestType { get; set; }
    public int PriorityLevel { get; set; }   // 1–5
    public int SeverityLevel { get; set; }   // 1–10
    public int EstimatedHours { get; set; }

    public Resident Resident { get; set; }

    public double UrgencyScore { get; set; }

    public ServiceRequest(string type, int priority, int severity, int hours, Resident resident)
    {
        RequestType = type;
        PriorityLevel = priority;
        SeverityLevel = severity;
        EstimatedHours = hours;
        Resident = resident;
    }
}