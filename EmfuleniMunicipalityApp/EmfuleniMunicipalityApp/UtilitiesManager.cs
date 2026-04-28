using System;
using System.Collections.Generic;
using System.Linq;

public class UtilitiesManager
{
    public static double CalculateUrgency(ServiceRequest request)
    {
       //formula
        return (request.PriorityLevel * 2) + (request.SeverityLevel * 3) - request.EstimatedHours;
    }
    //create the request for the variables
    public static void GenerateReport(ServiceRequest request)
    {
        Console.WriteLine("\n--- SERVICE REPORT ---");
        Console.WriteLine($"Resident: {request.Resident.Name}");
        Console.WriteLine($"Address: {request.Resident.Address}");
        Console.WriteLine($"Account: {request.Resident.AccountNumber}");

        Console.WriteLine($"Request Type: {request.RequestType}");
        Console.WriteLine($"Priority: {request.PriorityLevel}");
        Console.WriteLine($"Severity: {request.SeverityLevel}");
        Console.WriteLine($"Estimated Hours: {request.EstimatedHours}");

        Console.WriteLine($"Urgency Score: {request.UrgencyScore}");
        Console.WriteLine("----------------------\n");
    }
}