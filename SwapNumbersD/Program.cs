using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbersD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var result1 = TrySwapNumbers(100, 2);
			var result2 = TrySwapNumbers(2, 100);
			Console.WriteLine(string.Format("({0},{1})",result1.min,result1.max));
			Console.WriteLine(string.Format("({0},{1})", result2.min, result2.max));
			
			Console.ReadKey();
		}

		private static (int min,int max ) TrySwapNumbers(int n1, int n2)
		{
			return n1 <= n2 ? (n1, n2) : (n2, n1);
		}
	}
}
