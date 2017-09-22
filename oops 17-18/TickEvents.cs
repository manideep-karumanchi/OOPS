using System;
using System.Threading;
delegate void TickEvent();
class ClockEvent{
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
	static int sec=0,min=0,hour=0,day=0;
	static void Handler(){
		sec++;
		if(sec==60){
			sec=0;
			min++;
			if(min==60){
				min=0;
				hour++;
				if(hour==24){
					hour=0;
					day++;
				}
			}
		}
		Console.Clear();
		Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight/2);
		Console.WriteLine(day+":"+hour+":"+min+":"+sec);
	}
	static void Main(){
		Console.Clear();
		ClockEvent ce=new ClockEvent();
		ce.te+=Handler;
		ce.OnTickEvent();
	}
}