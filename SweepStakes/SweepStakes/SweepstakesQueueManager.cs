using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Random random = new Random();
        public Queue<Contestant> theContestantQueue = new Queue<Contestant>();
        public Queue<SweepStakes> theSweepStakesQueue = new Queue<SweepStakes>();
        public SweepStakes sweepstakes;
        public SweepstakesQueueManager()
        {
            for (int i = 0; i < 1000; i++)
            {
                theContestantQueue.Enqueue(new Contestant(i));
            }
        }
        public SweepStakes GetNextSweepstakesWinner()
        {
            sweepstakes = new SweepStakes("Mapes Grand Give Away");
            int thewinner = random.Next(0, 1000);
            foreach (Contestant person in theContestantQueue)
            {
                
                if (thewinner == person.ID)
                {
                    Console.WriteLine("The next winner will be " + person.name + " with an ID of " + person.ID + " queue");
                }                
            }
            return sweepstakes;                    
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            theSweepStakesQueue.Enqueue(new SweepStakes("Power Ball"));
            theSweepStakesQueue.Enqueue(new SweepStakes("DevCamp"));
        }
    }
}
