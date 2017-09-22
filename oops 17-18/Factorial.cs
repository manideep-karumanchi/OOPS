using System;
class Factorial{
	static int FactR(int num){
		int fact=1;
		if(num==1)
			return 1;
		fact*=num*FactR(num-1);
		return fact;
		 
	}
	static void Main(){
		int num=5;
		Console.WriteLine("Factorial of "+num+" is"+FactR(num));
		int fact=1;
		for(int i=num;i>=1;i--)
			fact=fact*i;
		Console.WriteLine("Factorial is:"+fact);
	}
}