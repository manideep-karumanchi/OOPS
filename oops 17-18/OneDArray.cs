using System;
class OneDArray{
	static double Mean(int[] numbers,int noofele){
		int sum=0;
		for(int i=0;i<noofele;i++){
			sum=sum+numbers[i];
		}
		return ((sum*1.0)/(noofele*1.0));
	}
	static void Main(){
		int[] numbers=new int[10];
		for(int i=0;i<10;i++){
			Console.Write("numbers["+i+"]=");
			numbers[i]=int.Parse(Console.ReadLine());
		}
		double mean=Mean(numbers,10);
		Console.WriteLine("Mean of numbers is:"+mean);
	}
}