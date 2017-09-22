using System;
class Circle{
	double r=5.0,PI=3.14;
	public double Area(){
		return PI*r*r;
	}
	public void Perimeter(){
		Console.WriteLine("Perimeter is:"+(2*PI*r));
	}
}
class CircleDemo{
	static void Main(){
		Circle c=new Circle();
		Console.WriteLine("Area is"+c.Area());
		c.Perimeter();
	}
}