using System;
class ObjectExample{
	int i;
	public ObjectExample(int a){
		i=a;
	}
	public void Show(){
		Console.WriteLine("i="+i);
	}
	public override String ToString(){
		return "object:ObjectExample";
	}
}
class Demo{
	static void Main(){
		ObjectExample o1=new ObjectExample(10);
		ObjectExample o2=new ObjectExample(10);
		Console.WriteLine("o1.Equals(o2)"+o1.Equals(o2));
		Console.WriteLine("o1.getHashCode()"+o1.GetHashCode());
		Console.WriteLine("o1.getType()"+o1.GetType());
		Console.WriteLine("o1.ReferenceEquals(o2)"+ReferenceEquals(o1,o2));
		Console.WriteLine("o1.ToString(o2)"+o1.ToString());
	}
}