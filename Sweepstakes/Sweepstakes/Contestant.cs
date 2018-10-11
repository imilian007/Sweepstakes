using System;
namespace Sweepstakes
{
    public class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private double registrationNumber;

        public Contestant(int RegistrationNumber, string FirstName, string LastName, string EmailAddress)
        {
        }

        public int RegistrationNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        private string GetInfoString(string message)
        {
            string infoString;
            Console.WriteLine(message);
            infoString = Console.ReadLine();
            return infoString;
        }

        private int GetInfoInt(string message)
        {
            int infoInt;
            Console.WriteLine(message);
            infoInt = int.Parse(Console.ReadLine());
            return infoInt;
        }

        public string ContestantInfoString(string message)
        {
            string infoString = GetInfoString(message);
            return infoString;
        }

        public int ContestantInfoInt(string message)
        {
            int infoInt = GetInfoInt(message);
            return infoInt;
        }
    }
}
