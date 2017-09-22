using System;
class OptionalArguments{
	void test(int a,int b=0,int c=0){
		Console.WriteLine("a="+a+"b="+b+"c="+c);
	}
	void test(int a,double b=0,int c=0){
		Console.WriteLine("a="+a+"b="+b+"c="+c);
	}
	static void Main(){
		OptionalArguments oa=new OptionalArguments();
		oa.test(10);
		oa.test(10,20);
		oa.test(10,20,30);
	}
}