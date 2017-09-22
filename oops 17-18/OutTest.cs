using System;
class OutTest{
	int a,b;
	OutTest(int i,int j){
		a=i;b=j;
	}
	static void RefSwap(ref OutTest o1,ref OutTest o2){
		OutTest temp=o1;
		o1=o2;
		o2=temp;
	}
	static void Main(){
		float frac;
		OutTest o1=new OutTest(10,20);
		OutTest o2=new OutTest(30,40);
		Console.WriteLine("Before Swap o1.a={0} and o1.b={1}",o1.a,o1.b);
		Console.WriteLine("Before Swap o2.a={0} and o2.b={1}",o2.a,o2.b);
		RefSwap(ref o1,ref o2);
		Console.WriteLine("After Swap o1.a={0} and o1.b={1}",o1.a,o1.b);
		Console.WriteLine("After Swap o2.a={0} and o2.b={1}",o2.a,o2.b);
	}
}