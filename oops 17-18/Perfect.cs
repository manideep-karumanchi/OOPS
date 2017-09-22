using System;
class Perfect{
	static void Main(){
		int num=6;
		int res=0;
		for(int i=1;i<=num/2;i++){
			if(num % i == 0)
				res=res+i;
		}
		if(num==res){
			Console.WriteLine(num+" is Perfect");
		}
	}
}