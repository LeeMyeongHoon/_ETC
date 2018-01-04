namespace mylib
{
	class MyWeightRandom
	{
		public MyWeightRandom(int[] weights)
		{
			length = weights.Length;
			weightSums = new int[weights.Length];
			weightSums[0] = weights[0];

			for (int i = 1; i < length; i++)
			{
				weightSums[i] = weightSums[i - 1] + weights[i];
			}

			randomMaker = new System.Random();
		}

		public int MakeRandomInt()
		{
			var random = randomMaker.Next(1, weightSums[length - 1]);

			for (int value = 0; value < length; ++value)
			{
				if (random <= weightSums[value])
				{
					return value;
				}
			}

			System.Diagnostics.Debug.Fail("MyRandom() Error");

			return length;
		}

		private int[] weightSums;
		private System.Random randomMaker;
		private int length;
	}
}
