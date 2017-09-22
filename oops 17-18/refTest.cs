using System;
class refTest{
	static void Swap(ref int a,ref int b){
		int t=a;
		a=b;
		b=t;
	}
	static void Main(){
		int x=10,y=20;
		Console.WriteLine("Before Swap:x={0},y={1}",x,y);
		Swap(ref x,ref y);
		Console.WriteLine("After Swap:x={0},y={1}",x,y);
	}
}