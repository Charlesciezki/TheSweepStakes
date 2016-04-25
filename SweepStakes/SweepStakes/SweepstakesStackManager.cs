using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Contestant> theContestantStack = new Stack<Contestant>();
        public Stack<SweepStakes> theSweepStakesStack = new Stack<SweepStakes>();
        public SweepStakes sweepstakes;
        Random random = new Random();
        public SweepstakesStackManager()
        {
            for (int i = 0; i < 1000; i++)
            {
                theContestantStack.Push(new Contestant(i));
            }
            
        }
        public SweepStakes GetNextSweepstakesWinner()
        {
            sweepstakes = new SweepStakes("The Charles Takes Your Money Give-Away");
            int theWinner = random.Next(0, 1001);
            foreach (Contestant person in theContestantStack)
            {
                
                if (theWinner == person.ID)
                {
                    Console.WriteLine("The next winner will be " + person.name + " with an ID of " + person.ID + " stack");
                }
            }
            return sweepstakes;
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            sweepstakes = new SweepStakes("The Charles Takes Your Money Give-Away");
            theSweepStakesStack.Push(sweepstakes);
        }
    }
}
