using System;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        // Properties
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        // Constructor
        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge();
        }

        // Age Calculation from first 6 digits of SA ID (YYMMDD)
        private int CalculateAge()
        {
            try
            {
                if (IDNumber.Length < 6) return 0;

                int year = int.Parse(IDNumber.Substring(0, 2));
                int month = int.Parse(IDNumber.Substring(2, 2));
                int day = int.Parse(IDNumber.Substring(4, 2));

                // Determine century: if year > current 2-digit year, it's 1900s
                int currentYear = DateTime.Now.Year % 100;
                int fullYear = (year > currentYear) ? 1900 + year : 2000 + year;

                DateTime birthDate = new DateTime(fullYear, month, day);
                DateTime today = DateTime.Today;

                int age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age)) age--;

                return age;
            }
            catch
            {
                return 0;
            }
        }

        // Validate ID Method
        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return " Invalid ID: Must be exactly 13 digits.";

            foreach (char c in IDNumber)
            {
                if (!char.IsDigit(c))
                    return "Invalid ID: Must contain numbers only.";
            }

            if (Age <= 0 || Age > 120)
                return "Invalid ID: Age could not be determined.";

            return $" Valid ID. Citizen is {Age} years old.";
        }
    }
}