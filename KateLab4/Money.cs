namespace KateLab4
{
    public class Money
    {
		private static int rubles
		{
			get
			{
				return rubles;
			}
			set
			{
				if (value > 0)
				{
					rubles = value;
				}
			}
		}
		private static int kopeks
		{
			get
			{
				return kopeks;
			}
			set
			{
				if (value > 0)
				{
					kopeks = value;
				}
			}
		}

		public double Minus(double num, int rubles, int kopeks)
		{
			double result;
			result = (rubles + (double)kopeks / 100) - num;
			if (result > 0)
				return result;
			return 0;

		}

		public void Plus(int kopeks)
		{
			if (kopeks < 99)
				kopeks++;

		}

		public void MinusKops(int kopeks)
		{
			if (kopeks > 0)
				kopeks--;

		}

		public double Rub(int rubles, int kopeks)
		{
			return rubles;

		}

		public double Kops(int rubles, int kopeks)
		{
			return kopeks;
		}
	}
}