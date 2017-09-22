using System;
class Rectangle{
	public int l=5,b=5;
	public Rectangle(){
		l=8;b=8;
	}
	public Rectangle(int length,int breadth){
		l=length;
		b=breadth;
	}
	public int Area(){
		return l*b;
	}
	public int Perimeter(){
		return 2*(l+b);
	}
}
class ShapesDemo{
	static void Main(){
		Rectangle r = new Rectangle();
		Rectangle r1=new Rectangle(6,6);
		
		Console.WriteLine("Area is:"+r.Area());
		Console.WriteLine("Perimeter is:"+r.Perimeter());
		
		Console.WriteLine("Area is:"+r1.Area());
		Console.WriteLine("Perimeter is:"+r1.Perimeter());
		
	}
}