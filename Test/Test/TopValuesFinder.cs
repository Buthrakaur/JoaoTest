using System;
using System.Linq;

namespace Test
{
	public class TopValuesFinder: IFindTopValues
	{
		public int FindMaxValue(int[] anyOldOrderValues)
		{
			/*this is just a specific case for FindTopNValues - I could call here:
			 * return FindTopNValues(anyOldOrderValues, 1)[0];
			 * but I rather use more simple Linq construct which could be more efficient
			 */

			if (anyOldOrderValues.Length == 0)
			{
				throw new ArgumentException("empty array is not allowed", "anyOldOrderValues");
			}
			return anyOldOrderValues.Max();
		}

		public int[] FindTopNValues(int[] anyOldOrderValues, int n)
		{
			if (anyOldOrderValues.Length == 0)
			{
				throw new ArgumentException("empty array is not allowed", "anyOldOrderValues");
			}
			if (n > anyOldOrderValues.Length)
			{
				throw new ArgumentOutOfRangeException("n", n, "count parameter must be less or equal to array length");
			}
			if (n < 0)
			{
				throw new ArgumentOutOfRangeException("n", n, "negative number is not allowed");
			}
			if (n == 0)
			{
				return new int[0];
			}

			return anyOldOrderValues.OrderByDescending(x => x)
				.Take(n)
				.ToArray();
		}
	}
}