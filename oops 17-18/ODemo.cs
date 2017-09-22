class A{
	public void Show(){
		Console.WriteLine("In A");
	}
}
class B:A{
	public void Show(){
		Console.WriteLine("In A");
	}
}
class ODemo{
	static void Main(){
		A a=new A();
		a.Show();
		a=new B();
		a.Show();
		B b=new B();
		b.Show();
	}
}