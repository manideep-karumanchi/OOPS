using System;
namespace Shapes1{
	class Circle{
		int radius;
		public Circle(int r){
			radius=r;
		}
		public void Area(){
			Console.WriteLine("Area is:"+(3.14*radius*radius));
		}
	}
	class Rectangle{
		int length,breadth;
		public Rectangle(int l,int b){
			length=l;
			breadth=b;
		}
		public void Area(){
			Console.WriteLine("Area is:"+(length*breadth));
		}
	}
}