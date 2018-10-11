using System;
using System.Collections.Generic;
namespace Sweepstakes
{
    public class Sweepstakes
    {
        private int contestantCount = 1;
        public Sweepstakes(string name)
        {
        }

        Dictionary<int, Contestant> contestantDictionary = new Dictionary<int, Contestant>();

        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = contestant.ContestantInfoString("First Name: ");
            contestant.LastName = contestant.ContestantInfoString("Last Name: ");
            contestant.EmailAddress = contestant.ContestantInfoString("Email: ");
            contestant.RegistrationNumber = contestantCount;
            contestantDictionary.Add(contestant.RegistrationNumber, contestant);
            contestantCount++;
        }

        public string PickWinner()
        {
            string winner;

            Random rnd = new Random();
            int Winner = rnd.Next(1 - contestantCount);

            winner = contestantDictionary[Winner].FirstName;

            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);
        }
    }
}
