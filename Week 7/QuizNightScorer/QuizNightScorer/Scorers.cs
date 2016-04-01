using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNightScorer
{
    public static class Scorers
    {
        public static int Adults(int correct, int incorrect)
        {
            return correct * 10 - incorrect;
        }

        public static int Children(int correct, int incorrect)
        {
            return correct * 15;
        }
    }
}
