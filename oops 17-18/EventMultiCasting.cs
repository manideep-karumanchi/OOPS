using System;
delegate void MyDelegate();
class EventMultiCasting{
	public event MyDelegate MyEvent;
	public void OnMyEvent(){
		if(MyEvent!=null)
			MyEvent();
	}
}
class X{
	int a;
	public X(int val){
		a=val;
	}
	public void XMyHandler(){
		Console.WriteLine("Event Recieved:a="+a);
	}
}
class MEH{
	static void Main(){
		EventMultiCasting emc=new EventMultiCasting();
		X o1=new X(1);
		X o2=new X(2);
		emc.MyEvent+=o1.XMyHandler;
		emc.MyEvent+=o2.XMyHandler;
		emc.OnMyEvent();
	}
}