using System;
class TwoDArray{
	static void Main(){
		int[,] m1={{1,2},{3,4}};
		int [,,] m2=new int [2,2,2];
		for(int r=0;r<3;r++)
			for(int c=0;c<3;c++){
				Console.Write("Enter value of m1["+r+"]"+"["+c+"]:");
				m1[r,c]=int.Parse(Console.ReadLine());
			}
		for(int r=0;r<2;r++)
			for(int c=0;c<2;c++){
				Console.Write("Enter value of m2["+r+"]"+"["+c+"]:");
				m2[r,c]=int.Parse(Console.ReadLine());
			}
		int [,] res=new int[2,2];
		for(int r=0;r<2;r++){
			for(int c=0;c<2;c++){
				res[r,c]=m1[r,c]+m2[r,c];
			}
		}
		for(int r=0;r<2;r++){
			for(int c=0;c<2;c++){
				Console.Write(res[r,c]);
			}
			Console.WriteLine();
		}
	}
}