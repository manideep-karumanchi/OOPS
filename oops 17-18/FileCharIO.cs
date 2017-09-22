using System;
using System.IO;
class FileCharIO{
	static void Main(){
		String fileName,str;
		Console.Write("Enter File Name:");
		fileName=Console.ReadLine();
		StreamWriter fw=new StreamWriter(fileName);
		Console.SetOut(fw);
		while((str=Console.ReadLine())!="stop"){
			Console.WriteLine(str+"\n");
		}
		fw.Close();
	}
}