using MissingNumberApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberApp.Services
{
    public class RangeMissingNumberProvider : IMissingNumbersFinder
    {
        public List<int> FindMissingNumbers(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new List<int>();

            int min = nums.Min();
            int max = nums.Max();

            var numSet = new HashSet<int>(nums);
            var missing = new List<int>();

            for (int i = min; i <= max; i++)
            {
                if (!numSet.Contains(i))
                    missing.Add(i);
            }

            return missing;
        }
    }
}
