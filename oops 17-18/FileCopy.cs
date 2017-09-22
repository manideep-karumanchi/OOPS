using System;
using System.IO;
class FileCopy{
	static void Main(String[] args){
		FileStream fs1,fs2;
		int ch;
		if(args.Length<2){
			Console.WriteLine("Error\nUsage:ProgramName File1 File2");
			return;
		}
		try{
			fs1=new FileStream(args[0],FileMode.Open,FileAccess.Read);
			fs2=new FileStream(args[1],FileMode.Create,FileAccess.Write);
			while((ch=fs1.ReadByte())!=-1){
				fs2.WriteByte((byte)ch);
			}
			fs1.Close();
			fs2.Close();
		}catch(FileNotFoundException ex){
			Console.WriteLine("File is Not Existed:\n"+ex);
		}catch(IOException ex){
			Console.WriteLine("IO Failure:\n"+ex);
		}catch(Exception ex){
			Console.WriteLine("General Exception:\n"+ex);
		}
	}
}