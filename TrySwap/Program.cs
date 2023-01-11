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
			int v1 = 2;
			int v2 = 100;
			
			Swap(ref v1, ref v2);
			Console.WriteLine(string.Format("{0},{1}",v1, v2));
			Console.WriteLine(string.Format("{0},{1}", v2, v1));
			
			Console.ReadKey();
		}

		

		private static void Swap<T>(ref T v1, ref T v2)
		{
			T temp=v1;
			v1=v2;
			v2=temp;		
		}
	

	}

	
}
