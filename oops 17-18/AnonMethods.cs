using System;
delegate int Print(int num);
class AnonMethods{
	static Print FindSum(int num){
		int sum=0;
		Print p=delegate(int end){
			for(int i=0;i<end;i++){
				Console.WriteLine(i);
				sum+=i;
			}
			return sum;
		};
		return p;
	}
	static void Main(){
		int num=5;
		Print p=FindSum(num);
		Console.WriteLine("Sum of 0 to {0} is:{1}",num,p(num));
		num=10;
		Console.WriteLine("Sum of 0 to {0} is:{1}",num,p(num));
		num=5;
		Console.WriteLine("Sum of 0 to {0} is:{1}",num,p(num));
	}
}