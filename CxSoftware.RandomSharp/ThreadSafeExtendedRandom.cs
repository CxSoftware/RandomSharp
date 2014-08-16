using System;

namespace CxSoftware.RandomSharp
{
	public static class ThreadSafeExtendedRandom
	{
		// Read-only fields

		[ThreadStatic]
		private static readonly ExtendedRandom random = new ExtendedRandom ();



		// Methods

		public static int Next (int minValue, int maxValue)
		{
			return random.Next (minValue, maxValue);
		}

		public static int Next (int maxValue)
		{
			return random.Next (maxValue);
		}

		public static int Next ()
		{
			return random.Next ();
		}

		public static void NextBytes (byte [] buffer)
		{
			random.NextBytes (buffer);
		}

		public static double NextDouble ()
		{
			return random.NextDouble ();
		}

		public static long NextInt64 ()
		{
			return random.NextInt64 ();
		}

		public static ulong NextUInt64 ()
		{
			return random.NextUInt64 ();
		}
	}
}

