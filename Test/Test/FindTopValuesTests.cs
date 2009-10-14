using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Test
{
	[TestFixture]
	public class FindTopValuesTests
	{
		[Test(Description = "FindMaxValue method should throw ArgumentException when empty array supplied as a parameter."),
		ExpectedException(typeof(ArgumentException))]
		public void FindMaxValue_Should_ThrowWhenEmptyArrayPassed()
		{
			var values = new int[0];
			var finder = new FindTopValues();
			finder.FindMaxValue();
		}
	}
}
