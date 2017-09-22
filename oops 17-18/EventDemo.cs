using System;
delegate void MyDelegate();
class EventDemo{
	public event MyDelegate MyEvent;
	public void OnMyEvent(){
		if(MyEvent!=null)
			MyEvent();
	}
}
class EventHandler{
	static void MyEventHandler(){
		Console.WriteLine("Event Occured");
	}
	static void Main(){
		EventDemo ed=new EventDemo();
		ed.MyEvent+=MyEventHandler;
		ed.OnMyEvent();
	}
}