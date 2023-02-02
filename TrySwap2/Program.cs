using System;
using System.Collections.Generic;

namespace TrySwap2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<TrySwap> list = new List<TrySwap>()
			{
				new TrySwap() { v1=2, v2=99 },
				new TrySwap(){v1=100,v2=2},   
				new TrySwap(){v1=250,v2=50},
					new TrySwap(){v1=55,v2=50}


		};
			list.Sort();
			foreach (TrySwap item in list)
			{
				Console.WriteLine(item.v1 + "," + item.v2);
			}

			Console.ReadKey();

			
		}
		//寫一個泛型版本的(T min, T max) TrySwap<T>(T vaule1, T value2)
	}

	public class TrySwap  : IComparable
	{
		public int v1;
		public int v2;

		

		public int CompareTo(object obj)
		{
			//TrySwap t = obj as TrySwap;
			var result = v1.CompareTo(v2) <= 0 ? (v1, v2) : (v2, v1);
			v1 = result.Item1;
			v2 = result.Item2;
			return v1.CompareTo(v2);
			
		}

		
		
	}
}

		
