using System;
class Printer{
	static void Main(){
		label:
		for(int i=1;i<=10;i++){
			
			if(i==5)
				goto label;
			Console.WriteLine(i);
		}
	}
}