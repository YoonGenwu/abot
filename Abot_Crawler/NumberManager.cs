using System;
using System.Collections.Generic;

namespace Abot_Crawler
{
	public class NumberManager62Ary
	{
		/// <summary>
		/// The number. Ones place at the first index.
		/// </summary>
		private List<Unit62Ary> number = null;

		public NumberManager62Ary() : this("0")
		{

		}

		public NumberManager62Ary(string originalDecimalValue)
		{
			number = new List<Unit62Ary>();
		}

		public 
	}

	public class Unit62Ary
	{
		private readonly static string dictionary = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

		private int innerIndex = 0;
		private char stringValue = '0';

		public Unit62Ary(int v = 0)
		{
			InnerIndex = v;
			stringValue = dictionary[InnerIndex];
		}

		public int InnerIndex
		{
			get
			{
				return innerIndex;
			}

			set
			{
				innerIndex = value > 61 ? 61 : value;
			}
		}
	}
}

