using System;
using System.Threading;
delegate void TickEventHandler();
class Clock
{
	public static event TickEventHandler th;
	public void Run()
	{
		while(true)
		{
			Thread.Sleep(2000);//2 seconds
			if(th!=null)
				th();
		}
	}
}
class A
{
	public A()
	{
		Clock.th+=TickHandlerA;
	}
	public void TickHandlerA()
	{
		Console.WriteLine("Tick Event Response from Class A");
	}
}
class B
{
	public B()
	{
		Clock.th+=TickHandlerB;
	}
	public void TickHandlerB()
	{
		Console.WriteLine("Tick Event Response from Class B");
	}
}
class EventDemo
{
	static void Main()
	{
		Clock c=new Clock();
		A o=new A();
		B b=new B();
		c.Run();
	}
}