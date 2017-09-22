using System;
delegate void StringMod(ref String s);
class MulticastDelegateEx{
	static void RemoveSpaces(ref String str){
		String temp="";
		Console.WriteLine("Before Removing Spaces:"+str);
		for(int i=0;i<str.Length-1;i++)
			if(str[i]!=' ')
				temp+=""+str[i];
				str=temp;
	}
	static void ReplaceSpaces(ref String str){
		Console.WriteLine("Before Replacing Spaces:"+str);
		String temp=str.Replace(' ','-');
		str=temp;
	}
	static void Reverse(ref String str){
		Console.WriteLine("Before Reverse Spaces:"+str);
		string temp="";
		for(int i=str.Length-1;i>=0;i--)
			temp+=""+str[i];
		str=temp;
	}
	static void Main(){
		StringMod sm;
		StringMod rs=RemoveSpaces;
		StringMod res=ReplaceSpaces;
		StringMod rev=Reverse;
		
		sm=res;
		String str="This is a String.";
		sm(ref str);
		Console.WriteLine("After Replacing Spaces:"+str);
		Console.WriteLine();
		
		sm+=rev;
		//sm = new StringMod(d.ReplaceSpaces);
		sm(ref str);
		Console.WriteLine("After Reversing Spaces:"+str);
		Console.WriteLine();
		
		sm-=res;
		//sm = new StringMod(d.ReplaceSpaces);
		sm(ref str);
		Console.WriteLine("After Reversing:"+str);
		Console.WriteLine();
	}
}