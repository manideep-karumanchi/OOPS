using System;
class StringExample{
	static void Main(){
		string s1="BEC BAPATLA",s2="CSE 2A",s3="bec bapatla",s4="   RP    ";
		Console.WriteLine("String.Compare("+s1+","+s2+"):"+String.Compare(s1,s2));
		Console.WriteLine("String.Compare("+s1+","+s3+"):"+String.Compare(s1,s3));
		Console.WriteLine("String.Compare("+s1+","+s3+",true):"+String.Compare(s1,s3,true));
		Console.WriteLine("String.Concat("+s1+","+s2+"):"+String.Concat(s1,s2));
		Console.WriteLine(s1+".Contains(\"BEC\"):"+s1.Contains("BEC"));
		Console.WriteLine(s1+".Contains(\"CSE\"):"+s1.Contains("CSE"));
		String temp=String.Copy(s1);
		Console.WriteLine("After Copy:"+temp);
		char[] ch=new char[s1.Length];
		s1.CopyTo(4,ch,0,7);
		Console.WriteLine("Copy To");
		foreach(char c in ch)
			Console.Write(c);
		Console.WriteLine();
		Console.WriteLine(s1+".EndsWith(\"BEC\"):"+s1.EndsWith("BEC"));
		Console.WriteLine(s1+".StartsWith(\"BEC\"):"+s1.StartsWith("BEC"));
		Console.WriteLine(s1+".Equals("+s2+"):"+s1.Equals(s2));
		Console.WriteLine(s1+".IndexOF(\"BEC\",0):"+s1.IndexOf("BEC",0));
		Console.WriteLine(s1+".IndexOFAny({'A','B','C'}):"+s1.IndexOfAny(new char[]{'A','B','C'}));
		Console.WriteLine(s1+".Insert(3,\"   \"):"+s1.Insert(3,"   "));
		Console.WriteLine("String.Join(",","+s1+","+s2+"):"+String.Join(",",s1,s2));
		Console.WriteLine("s4:"+s4+""+s4+".trim:"+s4.Trim());
		Console.WriteLine(String.Format("Welcome to {0}{1}",s1,s2));
	}
}