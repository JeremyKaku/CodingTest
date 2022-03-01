using System;

namespace bitFlyerTest
{
    class Program
    {
        static void Main()
        {
            double[,] trans = { { 57247, 98732, 134928, 77275, 29240, 15440, 70820, 139603, 63718, 143807, 190457, 40572 }, { 0.0887, 0.1856, 0.2307, 0.1522, 0.0532, 0.025, 0.1409, 0.2541, 0.1147, 0.266, 0.2933, 0.0686 } };
            double limit = 1000000;
            var output = GetMaxReward(limit, trans, 0) + 12.5;
            Console.WriteLine(output);
            Console.Read();
        }

        /// <summary>
        ///  Find the maximum possible reward (0/1 Knapsack Problem)
        /// </summary>
        /// <param name="limit">limit(bytes) of transactions</param>
        /// <param name="trans">transactions</param>
        /// <param name="k">start position (default 0)</param>
        /// <returns></returns>
        public static double GetMaxReward(double limit, double[,] trans, int k)
        {
            double reward, temp1, temp2;
            //last transaction
            if (k == trans.GetLength(1) - 1)
            {
                if (limit >= trans[0, k])
                {
                    reward = trans[1, k];
                }
                else
                {
                    reward = 0;
                }
            }
            //not exceed the upper limit
            else if (limit >= trans[0, k])
            {
                temp1 = GetMaxReward(limit - trans[0, k], trans, k + 1) + trans[1, k];
                temp2 = GetMaxReward(limit, trans, k + 1);
                reward = GetMax(temp1, temp2);
            }
            // exceed the upper limit
            else
            {
                reward = GetMaxReward(limit, trans, k + 1);
            }
            return reward;
        }

        public static double GetMax(double a, double b)
        {
            return a > b ? a : b;
        }
    }
}
