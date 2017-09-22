using System;
class ConsoleIn{
	static void Main(){
		char ch=(char)Console.In.Read();
		Console.In.ReadLine();
		Console.WriteLine(ch);
		String s=Console.In.ReadLine();
		Console.WriteLine(s);
	}
}