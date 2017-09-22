using System;
class calc{
	static decimal inv=100000m,interest=0.0m,total=100000m;
	static void Main(){
		Console.WriteLine("Total 1 year:"+total);
		for(int i=1;i<16;i++){
			interest=(total*0.00
			9m)*12;
			total=total+interest+inv;
			Console.WriteLine("Total "+(i+1)+" year:"+total);
		}
	}
}