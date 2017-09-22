using System;
class JaggedArray{
	static void Main(){
		int[][] ja = new int[3][];
		ja[0]=new int[3];
		ja[1]=new int[2];
		ja[2]=new int[1];
		for(int r=0;r<3;r++){
			for(int c=0;c<ja[r].Length;c++)
				ja[r][c]=int.Parse(Console.ReadLine());
		}
		for(int r=0;r<ja.Length;r++){
			for(int c=0;c<ja[r].Length;c++){
				Console.Write(ja[r][c]);
			}
			Console.WriteLine();
		}
	}
}