using System;
class UCDemo{
	static void Main(){
		byte a,b,r;
		a=(byte)127;
		b=(byte)127;
		try{
			checked{
				r=(byte)(a*b);
			}
			Console.WriteLine("r="+r);
		}catch(Exception e){
			Console.WriteLine(e);
		}
	}
	
}