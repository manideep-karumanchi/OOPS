using System;
interface TwoDShapes{
	int Length{
		get;
		set;
	}
	int Breadth{
		get;
		set;
	}
	double Area();
}
interface CircleOps{
	int Radius{
		get;
		set;
	}
	int this[int index]{
		get;
		set;
	}
	double Circumferance();
}
class Circle:TwoDShapes,CircleOps{
	int radius,length,breadth;
	public int Radius{
		private get{return radius;}
		set{radius=value;}
	}
	public int Length{
		get{return length;}
		set{length=value;}
	}
	public int Breadth{
		get{return breadth;}
		set{breadth=value;}
	}
	public int this[int index]{
		get{
			if(index==0)
				return radius;
			else return -1;
		}
		set{
			if(index==0)
				radius=value;
			else radius=0;
		}
	}
	public double Area(){
		return 3.14*radius*radius;
	}
	public double Circumferance(){
		return 2*3.14*radius;
	}
}
class newCircle:Circle{}
class Demo{
	static void Main(){
		Circle c=new Circle();
		c.Radius=5;
		Console.WriteLine(c.Area());
		Console.WriteLine(c.Circumferance());
	}
}