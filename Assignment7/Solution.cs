using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Solution
    {
        public int solution(int[] A)
        {
            int minPositive = int.MaxValue;
            bool foundPositive = false;

            foreach (int num in A)
            {
                if (num > 0)
                {
                    minPositive = Math.Min(minPositive, num);
                    foundPositive = true;

                }
            }

            if (!foundPositive)
            {
                return 0;
            }

            return minPositive * minPositive;



        }
    }
}
