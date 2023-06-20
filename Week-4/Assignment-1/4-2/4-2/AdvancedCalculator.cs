using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    public class AdvancedCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            var ans = a;
            for(var i = 0; i < b; i++)
            {
                ans++;
            }
            return ans;
        }

        public int Subtract(int a, int b)
        {
            var ans= a;
            for(var i = 0; i < b; i++)
            {
                ans--;
            }
            return ans;
        }
    }

}
