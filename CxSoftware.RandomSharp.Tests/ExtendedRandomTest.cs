using System;
using NUnit.Framework;

namespace CxSoftware.RandomSharp.Tests
{
	[TestFixture]
	public class ExtendedRandomTest
	{
		[Test]
		public void TestInt64 ()
		{
			var random = new ExtendedRandom ();
			var x = random.NextInt64 ();
			var y = random.NextInt64 ();
			Assert.AreNotEqual (x, y);
		}

		[Test]
		public void TestUInt64 ()
		{
			var random = new ExtendedRandom ();
			var x = random.NextUInt64 ();
			var y = random.NextUInt64 ();
			Assert.AreNotEqual (x, y);
		}
	}
}

