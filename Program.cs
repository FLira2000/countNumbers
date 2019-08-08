using System;
using System.Collections.Generic;

namespace countNumbers{

	class CountNumbers
	{
		public int countNumbers(int []arr, int lessThan){
			int lessThanCount = 0;
			List<int> auxList = new List<int>();
			
			for(int i = 0; i < arr.Length; i++){
				auxList.Add(arr[i]);
				if(arr[i] < lessThan){
					lessThanCount++;
				}
			}
			
			auxList.Sort();
			return lessThanCount;
		}
	}
	
	class Program{
		public static void Main(){
			CountNumbers cn = new CountNumbers();
			Console.WriteLine("Amostra = [1, 2, 3, 4, 5, 6]. lessThan = 4. ");
			Console.WriteLine("Execução retornou: {0}", cn.countNumbers(new int [] {1,2,3,4,5,6}, 4));
			Console.ReadKey(true);
		}
	}
}