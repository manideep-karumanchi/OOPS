using System;
class A{
	public A(){
		Console.WriteLine("Inside A");
	}
}
class B:A{
	public B(){
		Console.WriteLine("Inside B");
	}
}
class C:B{
	public C(){
		Console.WriteLine("Inside C");
	}
}
class test{
	static void Main(){
		new C();
	}
}