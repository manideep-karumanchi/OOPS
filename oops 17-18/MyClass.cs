using System;
interface One{
	void Show();
}
interface Two{
	void Show();
}
class MyClass:One,Two{
	void One.Show(){
		Console.WriteLine("One");
	}
	void Two.Show(){
		Console.WriteLine("Two");
	}
}
class Demo{
	static void Main(){
		One m=new MyClass();
		m.Show();
		Two t=new MyClass();
		t.Show();
	}
}