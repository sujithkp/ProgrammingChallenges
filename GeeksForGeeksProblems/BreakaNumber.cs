/*
Given a really large number N, break it into 3 whole numbers such 
that they sum up to the original number and find the number of ways 
to do so. Since this number can be very large, return it modulo 109+7.

    Input:
    N = 2
    Output:
    6
    Explanation:
    Possible ways to break the number:
    0 + 0 + 2 = 2 
    0 + 2 + 0 = 2
    2 + 0 + 0 = 2
    0 + 1 + 1 = 2
    1 + 1 + 0 = 2
    1 + 0 + 1 = 2
*/

namespace GeeksForGeeksProblems
{
    public  class BreakaNumber
    {
        public int waysToBreakNumber(int N)
        {
            long a = N;
            return (int) (((a + 1) * (a + 2)) / 2 % 10000007);
        }
    }
}
