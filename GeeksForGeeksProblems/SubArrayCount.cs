//https://practice.geeksforgeeks.org/problems/zero-sum-subarrays1825/1?page=1&company[]=Microsoft&curated[]=1&sortBy=submissions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems
{
    public class SubArrayCount
    {
        public static int GetSubArrayCount(int[] a)
        {
            int n = a.Length;
            int sum = 0;
            int count = 0;
            var mp = new Dictionary<int, List<int>>();

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
                if (sum == 0)
                {
                    count++;
                }
                if (mp.Keys.Contains(sum))
                {
                    count += mp[sum].Count();
                }

                if (!mp.Keys.Contains(sum))
                    mp.Add(sum, new List<int>());

                mp[sum].Add(i + 1);
            }
            
            return count;
        }
    }
}
