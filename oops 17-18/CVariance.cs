using System;
class X{
	public int val;
}
class Y:X{}
delegate X increment(Y arg);
class cvariance{
	static X incrX(X arg){
		arg.val+=1;
		return arg;
	}
	static Y incrY(Y arg){
		arg.val+=1;
		return arg;
	}
	static void Main(){
		//Contra variance
		increment incr1=incrX;
		X x=incr1(new Y());
		Console.WriteLine("X.val="+x.val);
		
		//covariance
		increment incr2=incrY;
		x=(X)incr2(new Y());
		Console.WriteLine("X.val="+x.val);
	}
}