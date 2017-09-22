using System;
class AIP{
	public AIP(){
		Test="Hello";
	}
	public String Test{
		get;
		private set;
	}
	
}
class AIPTest{
	static void Main(){
		AIP ob=new AIP();
		//ob.Test="Hello";
		Console.WriteLine(ob.Test);
	}
}