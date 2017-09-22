using System;
using System.Threading;
delegate void TickEvent();
class Clock{
	public event TickEvent te;
	public void OnTickEvent(){
		for(;;){
			Thread.Sleep(1000);
			if(te!=null){
				te();
			}
		}
	}
}
class EventHandler{
	static int sec=0,min=0,hour=0,days=0;
	static void Handler(){
		sec++;
		if(sec==60){
			min++;
			sec=0;
			if(min==60){
				hour++;
				min=0;
				if(hour==24){
					days++;
					hour=0;
				}
			}
		}
		Console.Clear();
		Console.SetCursorPosition(Console.WindowWidth/2,Console.WindowHeight/2);
		Console.WriteLine(days+":"+hour+":"+min+":"+sec);
	}
	static void Main(){
		Clock c=new Clock();
		c.te+=Handler;
		c.OnTickEvent();
	}
}