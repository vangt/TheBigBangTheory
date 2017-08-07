using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigBangTheoryGame.Classes
{
    public class Players
    {
        public string name;

        public double score;

        public bool isAI;

        public Players()
        {
        }

        public virtual string GetChoice()
        {
            return "";
        }
    }
}
