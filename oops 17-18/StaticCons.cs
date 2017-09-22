using System;
class StaticCons{
	static int sv;
	int nsv;
	static StaticCons(){
		sv=100;
	}
	public StaticCons(int val){
		nsv=val;
	}
	public void Show(){
		Console.WriteLine("sv={0},nsv={1}",sv,nsv);
	}
}
class StaticConsDemo{
	static void Main(){
		StaticCons sc=new StaticCons(100);
		sc.Show();
	}
}