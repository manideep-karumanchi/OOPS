using System;
class StringEx{
	static string method(){
		return "Welcome";
	}
	static void Main(){
		String str = "BEC";
		string str1= "BEC"+"Bapatla";
		char[] ch={'C','S','E','-','A'};
		string str2=new String(ch);
		string str3=method();
		Console.WriteLine(str3+"\n"+str2+"\n"+str1+"\n"+str);
	}
}