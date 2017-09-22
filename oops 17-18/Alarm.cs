using System;
using System.Media;
delegate void AlarmDelegate();
class Alarm{
	public event AlarmDelegate alarm;
	public void OnAlarm(String time){
		for(;;){
			if(time.Equals(DateTime.Now.ToString("HH:mm"))){
				alarm();
			}
		}
	}
}
class Handler{
	static void AlarmHandler(){
		//new SoundPlayer(@"E:\Short-ringtone-for-notification.mp3").Play();
		Console.WriteLine("Event Received");
	}
	static void Main(){
		Alarm a=new Alarm();
		a.alarm+=AlarmHandler;
		a.OnAlarm("15:26");
	}
}