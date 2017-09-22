using System;
class POI{
	public String Test{
		get;
		set;
	}
	public int ITest{
		get;
		set;
	}
	
}
class AIPTest{
	static void Main(){
		POI ob=new POI{Test="Hello",ITest=100};
		//ob.Test="Hello";
		Console.WriteLine(ob.Test+","+ob.ITest);
	}
}