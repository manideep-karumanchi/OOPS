using System;
using System.IO;
class FileIO{
	static void Main(String[] args){
		FileStream fs;
		int c;
		if(args.Length>=1){
			try{
				fs=new FileStream(args[0],FileMode.Open);
				while((c=fs.ReadByte())!=-1){
					Console.Write((char)c);
				}
			}catch(FileNotFoundException exec){
				Console.WriteLine("File Not Found"+exec);
			}
			catch(IOException exec){
				Console.WriteLine("IO Error"+exec);
			}
			fs.Close();
		}
		else{
			Console.WriteLine("Usage: ProgramName FileName");
			return;
		}
	}
}