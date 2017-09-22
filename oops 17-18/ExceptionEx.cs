using System;
class ExceptionDemo{
	static int divide(int a,int b){
		int r=0;
		try{
			r=a/b;
			
		}catch(DivideByZeroException exob){
			Console.WriteLine(exob.Message);
			Console.WriteLine(exob.StackTrace);
			Console.WriteLine(exob.TargetSite);
			r=0;
		}
		return r;
	}
	static void Main(){
		int r=0;
		r=divide(100,0);
		Console.WriteLine(r);
	}
}