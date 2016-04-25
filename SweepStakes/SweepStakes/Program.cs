using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepStakes sweepstakes = new SweepStakes();
            Contestant contestant = new Contestant();
            SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
            SweepstakesStackManager stackManager = new SweepstakesStackManager();
            sweepstakes.addContestant();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PrintContestantInfo(contestant);
            queueManager.GetNextSweepstakesWinner();
            stackManager.GetNextSweepstakesWinner();
            Console.ReadLine();
        }
    }
}
