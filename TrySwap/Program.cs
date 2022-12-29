using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySwap
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var result1 = TrySwap<int>.SwapCompare(2, 100);
			var result2 = TrySwap<int>.SwapCompare(100, 2);
			Console.WriteLine(result1);
			Console.WriteLine(result2);
			Console.ReadKey();
		}


		public class TrySwap<T> where T : IComparable
		{
			public static T SwapCompare(T vaule1, T value2)
			{
				if (vaule1.CompareTo(value2) > 0)
				{
					return vaule1;
				}
				else { return value2; }

			}
		}
}
