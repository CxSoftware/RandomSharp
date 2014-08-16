using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;

namespace CxSoftware.RandomSharp.Tests
{
	[TestFixture]
	public class ThreadSafeExtendedRandomTest
	{
		[Test]
		public void TestMultiThreaded ()
		{
			Action action = () => { for (var x = 1; x < 1000; x++) ThreadSafeExtendedRandom.NextUInt64 (); };
			for (int i = 1; i <= 10; i++)
				new Thread (new ThreadStart (action)).Start ();
		}
	}
}

