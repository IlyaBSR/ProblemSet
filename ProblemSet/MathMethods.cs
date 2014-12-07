using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    public class MathMethods
    {

        public static uint ReverseInt(uint inputInt)
        {
            uint output = 0;

            while(inputInt > 0)
            {
                output = output * 10 + inputInt % 10;
                inputInt /= 10;
            }

            return output;
        }
    }
}
