public class Resident
{
    //set your public classes
    public string Name { get; set; }
    public string Address { get; set; }
    public string AccountNumber { get; set; }
    public double MonthlyUsage { get; set; }

    public Resident(string name, string address, string accountNumber, double monthlyUsage)
    {
        Name = name;
        Address = address;
        AccountNumber = accountNumber;
        MonthlyUsage = monthlyUsage;
    }
}