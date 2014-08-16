using System;

namespace CxSoftware.RandomSharp
{
	public class ExtendedRandom : Random
	{
		// Constructors

		public ExtendedRandom ()
		{
		}

		public ExtendedRandom (int seed) : base (seed)
		{
		}



		// Methods

		public long NextInt64 ()
		{
			var bytes = new byte [8];
			this.NextBytes (bytes);
			return BitConverter.ToInt64 (bytes, 0);
		}

		public ulong NextUInt64 ()
		{
			var bytes = new byte [8];
			this.NextBytes (bytes);
			return BitConverter.ToUInt64 (bytes, 0);
		}
	}
}

