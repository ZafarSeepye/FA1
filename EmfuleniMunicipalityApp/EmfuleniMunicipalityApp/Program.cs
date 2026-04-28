using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Resident> residents = new List<Resident>();
        List<ServiceRequest> requests = new List<ServiceRequest>();

        // 1. Add Residents
        Console.Write("Enter number of residents: ");
        int residentCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < residentCount; i++)
        {
            Console.WriteLine($"\nResident {i + 1}");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            string account = Console.ReadLine();

            Console.Write("Monthly Usage: ");
            double usage = double.Parse(Console.ReadLine());

            residents.Add(new Resident(name, address, account, usage));
        }

        // 2. Add Service Requests
        Console.Write("\nEnter number of service requests: ");
        int requestCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < requestCount; i++)
        {
            Console.WriteLine($"\nRequest {i + 1}");

            Console.Write("Select Resident Index (0 to " + (residents.Count - 1) + "): ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Request Type: ");
            string type = Console.ReadLine();

            Console.Write("Priority (1-5): ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Severity (1-10): ");
            int severity = int.Parse(Console.ReadLine());

            Console.Write("Estimated Hours: ");
            int hours = int.Parse(Console.ReadLine());

            ServiceRequest req = new ServiceRequest(type, priority, severity, hours, residents[index]);

            req.UrgencyScore = UtilitiesManager.CalculateUrgency(req);

            requests.Add(req);
        }

        // 3. Show Queue (sorted by urgency)
        var queue = requests.OrderByDescending(r => r.UrgencyScore).ToList();

        Console.WriteLine("\n--- REQUEST QUEUE ---");
        foreach (var r in queue)
        {
            Console.WriteLine($"{r.RequestType} - Urgency: {r.UrgencyScore}");
        }

        // 4. Process Requests
        List<ServiceRequest> completed = new List<ServiceRequest>();

        foreach (var r in queue)
        {
            Console.WriteLine("\nProcess this request? (y/n)");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                UtilitiesManager.GenerateReport(r);
                completed.Add(r);
            }
        }

        // 5. Summary
        Console.WriteLine("\n--- SUMMARY ---");

        foreach (var r in completed)
        {
            Console.WriteLine($"{r.RequestType} - {r.UrgencyScore}");
        }

        var highest = completed.OrderByDescending(r => r.UrgencyScore).FirstOrDefault();

        if (highest != null)
        {
            Console.WriteLine($"\nHighest Urgency: {highest.RequestType} ({highest.UrgencyScore})");
        }

        Console.WriteLine("\nAll requests processed.");
    }
}