using System;
class RATest{
	static void Main(){
		RangingArray ra=new RangingArray(-5,5);
		Console.WriteLine("RA Length is:"+ra.Length);
		for(int i=-5;i<=5;i++)
			ra[i]=i;
		for(int i=-5;i<=5;i++)
			Console.Write(ra[i]+"\t");
		Console.WriteLine();
		RangingArray ra1=new RangingArray(-1,5);
		Console.WriteLine("RA1 Length is:"+ra1.Length);
		for(int i=-1;i<=5;i++)
			ra1[i]=i;
		for(int i=-1;i<=5;i++)
			Console.Write(ra1[i]+"\t");
		Console.WriteLine();
		
		RangingArray ra2=new RangingArray(2,5);
		Console.WriteLine("RA2 Length is:"+ra2.Length);
		for(int i=2;i<=5;i++)
			ra2[i]=i;
		for(int i=2;i<=5;i++)
			Console.Write(ra2[i]+"\t");
		Console.WriteLine();
	}
}