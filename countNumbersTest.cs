using System;
using NUnit.Framework;

namespace countNumbers
{
	[TestFixture]
	public class CountNumbersTest
	{
		[Test]
		public void countNumbers()
		{
			CountNumbers cn = new CountNumbers();
			Assert.AreEqual(3, cn.countNumbers(new int [] {1,2,3,4,5,6}, 4));
			
		}
	}
}
