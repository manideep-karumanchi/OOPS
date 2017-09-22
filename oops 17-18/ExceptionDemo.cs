using System;
class ExceptionDemo{
	static int divide(int a,int b){
		int r=a/b;
		return r;
	}
	static void Main(){
		int[] n={50,10,3,5,7,8,25,100},d={1,5,0,3,0};
		int r=0;
		for(int i=0;i<n.Length;i++){
			try{
				r=divide(n[i],d[i]);
				Console.WriteLine(r);
			}catch(DivideByZeroException exob){
				Console.WriteLine(exob.Message);
				Console.WriteLine(exob.StackTrace);
				Console.WriteLine(exob.TargetSite);
				r=0;
			}
			catch(IndexOutOfRangeException exob){
				Console.WriteLine("Index was out of Range");
			}
			finally{
				Console.WriteLine("Finally Block");
			}
		}
	}
}