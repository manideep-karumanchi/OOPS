using System;
class Factory{
	public int i,j;
	public static Factory objectFactory(int i, int j){
		Factory f=new Factory();
		f.i=i;
		f.j=j;
		return f;
	}
}
class StaticConsDemo{
	static void Main(){
		Factory f=Factory.objectFactory(10,20);
		Console.WriteLine(f.i+","+f.j);
	}
}