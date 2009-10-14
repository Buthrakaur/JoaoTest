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
		private IFindTopValues finder;

		[TestFixtureSetUp]
		public void TestFixtureSetup()
		{
			finder = new TopValuesFinder();
		}

		[Test(Description = "FindMaxValue method should throw ArgumentException when empty array supplied as a parameter."),
		ExpectedException(typeof(ArgumentException))]
		public void FindMaxValue_Should_ThrowWhenEmptyArrayPassed()
		{
			finder.FindMaxValue(new int[0]);
		}

		[Test(Description = "FindMaxValue should return max value from supplied array.")]
		public void FindMaxValue_Should_ReturnMaxValue()
		{
			Assert.AreEqual(1, finder.FindMaxValue(new[] {1}));
			Assert.AreEqual(5, finder.FindMaxValue(new[] {1, 3, 5, 2, 3, -999}));
		}

		[Test(Description = "FindTopNValues method should throw ArgumentException when empty array supplied as a parameter."),
		ExpectedException(typeof(ArgumentException))]
		public void FindTopNValues_Should_ThrowWhenEmptyArrayPassed()
		{
			finder.FindTopNValues(new int[0], 1);
		}

		[Test(Description = "FindTopNValues method should throw ArgumentOutOfRangeException when count parameter is greater than length of array."),
		ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void FindTopNValues_Should_ThrowWhenCountIsGreaterThanArrayLength()
		{
			finder.FindTopNValues(new[] { 1, 2, 3 }, 5);
		}

		[Test(Description = "FindTopNValues method should throw ArgumentOutOfRangeException when negative number supplied as count parameter."),
		ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void FindTopNValues_Should_ThrowWhenNegativeCountPassed()
		{
			finder.FindTopNValues(new[]{1,2,3}, -1);
		}
	
		[Test(Description = "FindTopNValues method should return empty array if count parameter equals zero."),
		ExpectedException(typeof(ArgumentException))]
		public void FindTopNValues_Should_ReturnEmptyArrayWhenNIsZero()
		{
			Assert.AreEqual(0, finder.FindTopNValues(new[] {1, 2, 3}, 0).Length);
		}

		[Test(Description = "FindTopNValues method should return top N values (in descending order) from supplied array.")]
		public void FindTopNValues_Should_ReturnTopNValues()
		{
			var topValues = finder.FindTopNValues(new[] {9, 5, 3, 8, 7, 666, -5, 0, 333, -777, int.MinValue}, 3);
			Assert.AreEqual(3, topValues.Length);
			Assert.AreEqual(666, topValues[0]);
			Assert.AreEqual(333, topValues[1]);
			Assert.AreEqual(9, topValues[2]);
		}
	}
}
