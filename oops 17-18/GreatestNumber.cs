using System;
class GreatestNumber{
	static void Main(){
		int n1=40,n2=32,n3=30;
		if(n1>=n2){
			if(n1>=n3){
				Console.WriteLine(n1+" is Greatest");
			}
			else{
				Console.WriteLine(n3+" is Greatest");
			}
		}
		else{
			if(n2>=n3){
				Console.WriteLine(n2+" is Greatest");
			}
			else{
				Console.WriteLine(n3+" is Greatest");
			}
		}
	}
}