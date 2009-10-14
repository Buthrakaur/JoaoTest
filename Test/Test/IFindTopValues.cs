using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
	public interface IFindTopValues
	{
		int FindMaxValue(int[] anyOldOrderValues);
		int[] FindTopNValues(int[] anyOldOrderValues, int n);
	}
}
