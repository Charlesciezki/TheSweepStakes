using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        
        Random random = new Random();
        public Contestant contestant = new Contestant();
        public List<Contestant> listOfContestants = new List<Contestant>();
        public SweepStakes() { }
        public SweepStakes(string sweepstakesName) { }
        public void addContestant()
        {
            for (int i = 0; i < 1000; i++)
            {
                listOfContestants.Add(new Contestant(i));
            }
        }
    public void RegisterContestant(Contestant contestant)
        {
            listOfContestants.Add(contestant);
        }
    public string PickWinner()
        {
            int theWinner = random.Next(0, 1001);
            string winner = listOfContestants[theWinner].name;
            Console.WriteLine("The winner is " + listOfContestants[theWinner].name + " with the ID " + listOfContestants[theWinner].ID);
            return winner;
        }
    public void PrintContestantInfo(Contestant contestant)
        {
            string theWinner = PickWinner();
            Console.WriteLine(theWinner);
        }

    }
}
