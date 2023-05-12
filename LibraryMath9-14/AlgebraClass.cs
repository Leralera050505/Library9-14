using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMath9_14
{
    public class AlgebraClass
    {
        public static double Summ(double[] doubles)
        {
            double sum = 0;
            for (int i = 0; i < doubles.Length; i++)
            {
                sum += doubles[i];
            }
            return sum;
        }
        public static double Max(double[] max)
        {
            double maxSum = max[0];
            for (int i = 0; i < max.Length; i++)
            {
                if (maxSum < max[i])
                {
                    maxSum = max[i];
                }
            }
            return maxSum;
        }
        public static double Min(double[] min)
        {
            double minSum = min[0];
            for (int i = 0; i < min.Length; i++)
            {
                if (minSum > min[i])
                {
                    minSum = min[i];
                }
            }
            return minSum;
        }
        public static double Sred(double[] sr)
        {
            double sum = 0;
            int count = 0;
            double Sr = 0;
            for (int i = 0; i < sr.Length; i++)
            {
                count += i;
                sum += sr[i];
            }
            Sr = sum / count;
            return Sr;
        }
    }
}
