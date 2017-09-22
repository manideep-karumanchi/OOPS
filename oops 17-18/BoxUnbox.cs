using System;
class ObjectExample{
	int i;
	public ObjectExample(int a){
		i=a;
	}
	public void Show(){
		Console.WriteLine("i="+i);
	}
	public override String ToString(){
		return "object:ObjectExample";
	}
}
class Demo{
	static void Main(){
		Object o1=new Object();
		int i=10;
		o1=i;
		
	}
}