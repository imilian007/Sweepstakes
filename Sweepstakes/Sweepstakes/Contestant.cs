using System;
namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public double registrationNumber;

        public Contestant()
        {
        }

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
