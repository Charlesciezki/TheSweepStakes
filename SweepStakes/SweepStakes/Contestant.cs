using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        public string name;
        public int ID;
        public List<string> names = new List<string> { "Paul Walkie", "Jim Talkie", "Charles YaBoi", "Mike", "Susie Jonies", "Andy Anyett", "Jeff Abel", "Sir Bearington" }; //0-7
        public Random random = new Random();
        public Contestant(int ID)
        {
            this.ID = ID;
            int nameChoice = random.Next(0, 8);
            name = names[nameChoice];
        }
        public Contestant()
        {

        }
    }
}
