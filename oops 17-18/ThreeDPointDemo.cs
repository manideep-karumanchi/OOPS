using System;
class ThreeDPoint{
	int x,y,z;
	public ThreeDPoint(){
		x=y=z=0;
	}
	public ThreeDPoint(int i,int j,int k){
		x=i;y=j;z=k;
	}
	public void Show(){
		Console.WriteLine("("+x+","+y+","+z+")");
	}
	public static ThreeDPoint operator +(ThreeDPoint p1,ThreeDPoint p2){
		ThreeDPoint p3=new ThreeDPoint();
		p3.x=p1.x+p2.x;
		p3.y=p1.y+p2.y;
		p3.z=p1.z+p2.z;
		return p3;
	}
	public static ThreeDPoint operator +(ThreeDPoint p1,int x){
		ThreeDPoint p3=new ThreeDPoint();
		p3.x=p1.x+x;
		p3.y=p1.y+x;
		p3.z=p1.z+x;
		return p3;
	}
	public static ThreeDPoint operator +(int x,ThreeDPoint p1){
		ThreeDPoint p3=new ThreeDPoint();
		p3.x=p1.x+x;
		p3.y=p1.y+x;
		p3.z=p1.z+x;
		return p3;
	}
	public static ThreeDPoint operator ++(ThreeDPoint p1){
		ThreeDPoint p3=new ThreeDPoint();
		p3.x=p1.x+1;
		p3.y=p1.y+1;
		p3.z=p1.z+1;
		return p3;
	}
	public static bool operator <(ThreeDPoint p1,ThreeDPoint p2){
		return Math.Sqrt(p1.x*p1.x+p1.y*p1.y+p1.z*p1.z)<Math.Sqrt(p2.x*p2.x+p2.y*p2.y+p2.z*p2.z);
	}
	/*public static bool operator |(ThreeDPoint p1,ThreeDPoint p2){
		return ((p1.x!=0||p1.y!=0||p1.z!=0)|(p2.x!=0||p2.y!=0||p2.z!=0));
	}
	public static bool operator &(ThreeDPoint p1,ThreeDPoint p2){
		return ((p1.x!=0||p1.y!=0||p1.z!=0)&(p2.x!=0||p2.y!=0||p2.z!=0));
	}*/
	public static ThreeDPoint operator |(ThreeDPoint p1,ThreeDPoint p2){
		if((p1.x!=0||p1.y!=0||p1.z!=0)|(p2.x!=0||p2.y!=0||p2.z!=0))
			return new ThreeDPoint(1,1,1);
		else
			return new ThreeDPoint(0,0,0);
	}
	public static ThreeDPoint operator &(ThreeDPoint p1,ThreeDPoint p2){
		if((p1.x!=0||p1.y!=0||p1.z!=0)&(p2.x!=0||p2.y!=0||p2.z!=0))
			return new ThreeDPoint(1,1,1);
		else
			return new ThreeDPoint(0,0,0);
	}
	public static bool operator >(ThreeDPoint p1,ThreeDPoint p2){
		return Math.Sqrt(p1.x*p1.x+p1.y*p1.y+p1.z*p1.z)>Math.Sqrt(p2.x*p2.x+p2.y*p2.y+p2.z*p2.z);
	}
	public static bool operator true(ThreeDPoint p1){
		if(p1.x!=0||p1.y!=0||p1.z!=0){
			return true;
		}
		else{
			return false;
		}
	}
	public static bool operator false(ThreeDPoint p1){
		if(p1.x==0&&p1.y==0&&p1.z==0){
			return true;
		}
		else{
			return false;
		}
	}
	public static ThreeDPoint operator --(ThreeDPoint p1){
		ThreeDPoint p3=new ThreeDPoint();
		p3.x=p1.x-1;
		p3.y=p1.y-1;
		p3.z=p1.z-1;
		return p3;
	}
	public static explicit operator int(ThreeDPoint p1){
		return p1.x+p1.y+p1.z;
		
	}
}
class ThreeDPointDemo{
	static void Main(){
		ThreeDPoint p1=new ThreeDPoint();
		Console.WriteLine("Point p1 is:");
		p1.Show();
		ThreeDPoint p2=new ThreeDPoint(10,20,30);
		Console.WriteLine("Point p2 is:");
		p2.Show();
		if(p1||p2) Console.WriteLine("p1|p2 is: true");
		else Console.WriteLine("p1|p2 is: false");
		if(p1&&p2) Console.WriteLine("p1&p2 is: true");
		else Console.WriteLine("p1&p2 is: false");
		ThreeDPoint p3=p2+p1;
		Console.WriteLine("Point p3 is:");
		p3.Show();
		ThreeDPoint p4=++p1;
		Console.WriteLine("Point p4 is:");
		p4.Show();
		ThreeDPoint p5=p1+5;
		Console.WriteLine("Point p5 is:");
		p5.Show();
		Console.WriteLine("p1<p2"+(p1<p2));
		if(p1){
			Console.WriteLine("true");
		}
		else{
			Console.WriteLine("false");
		}
		ThreeDPoint p6=new ThreeDPoint(10,10,10);
		do{
			Console.WriteLine("p6 is:");
			p6.Show();
			p6--;
		}while(p6);
		Console.WriteLine((int)p2);
		
	}
}