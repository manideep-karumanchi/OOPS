using System;
delegate String StringMod(String s);
class DelegateEx{
	String RemoveSpaces(String str){
		String temp="";
		Console.WriteLine("Before Removing Spaces:"+str);
		for(int i=0;i<str.Length-1;i++)
			if(str[i]!=' ')
				temp+=""+str[i];
		return temp;
	}
	String ReplaceSpaces(String str){
		Console.WriteLine("Before Replacing Spaces:"+str);
		String temp=str.Replace(' ','-');
		return temp;
	}
	static void Main(){
		DelegateEx d = new DelegateEx();
		StringMod sm = d.RemoveSpaces;
		String str = sm("This is a String.");
		Console.WriteLine("After Removing Spaces:"+str);
		Console.WriteLine();
		
		sm = new StringMod(d.ReplaceSpaces);
		str = sm("This is a String.");
		Console.WriteLine("After Replacing Spaces:"+str);
		Console.WriteLine();
	}
}