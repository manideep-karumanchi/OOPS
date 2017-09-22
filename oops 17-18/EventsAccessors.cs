using System;
delegate void MyDelegate();
class EventDemo{
	MyDelegate[] md=new MyDelegate[3];
	public event MyDelegate MyEvent{
		add{
			for(int i=0;i<=3;i++){
				if(i<3&&md[i]==null){
					md[i]=value;
					break;
				}
				if(i==3)Console.WriteLine("List is Full");
			}
		}
		remove{
			for(int i=0;i<=3;i++){
				if(i<3&&md[i]==value){
					md[i]-=value;
					break;
				}
				if(i==3)Console.WriteLine("Handler Not assigned");
			}
		}
	}
	public void OnMyEvent(){
		for(int i=0;i<3;i++)
			if(md[i]!=null)
			md[i]();
	}
}
class EventHandler{
	static void MyEventHandler(){
		Console.WriteLine("Event Occured");
	}
	static void Main(){
		EventDemo ed=new EventDemo();
		for(int i=0;i<=3;i++){
			ed.MyEvent+=MyEventHandler;
		}
		
		ed.OnMyEvent();
		//ed.MyEvent-=MyEventHandler;
	}
}