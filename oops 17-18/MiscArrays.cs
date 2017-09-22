using System;
class MiscArrays{
	static void Main(){
		int[,] a={{1,2},{3,4},{5,6}};
		int[,] b=a;
		foreach(int v in a){
			Console.Write(v);
		}
		Console.WriteLine();
		//b[5]=10;
		foreach(int v in a){
			Console.Write(v);
		}
		Console.WriteLine();
		foreach(int v in b){
			Console.Write(v);
		}
	}
}