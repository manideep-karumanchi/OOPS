C# 14CSL303 Lab Record Programs
//Lab01-List
using System;

class List
{
	int[] a;
	public int sz,n;
	
	public List(int m)
	{
		a=new int[m];
		sz=m;
		n=0;
	}
	public void ReadElements()
	{
		Console.Write("Enter no.of elements:");
		n=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter elements:");
		for(int i=0;i<n;i++)
			a[i]=int.Parse(Console.ReadLine());
	}
	
	public void Insert(int p,int x)
	{
		for(int i=n-1;i>=p;i--)
		{
			a[i+1]=a[i];
			if(i==p)
				a[p]=x;
		}
		n++;
	}
	public void Delete(int p)
	{
		for(int i=p;i<n-1;i++)
		{
			a[i]=a[i+1];
		}
		n--;
	}
	public int FindEle(int e)
	{
		for(int i=0;i<n;i++)
			if(a[i]==e)
				return i;
		return -1;
	}
	public void SortList()
	{
		for(int i=0;i<n;i++)
			for(int j=i;j<n;j++)
				if(a[i]>a[j])
					Swap(i,j);
	}
	public void Swap(int i,int j)
	{
		int t=a[i];
		a[i]=a[j];
		a[j]=t;
	}
	public void Reverse()
	{
		int i,j;
		for(i=0,j=n-1;i<j;i++,j--)
			Swap(i,j);
	}
	public void Print()
	{
		Console.WriteLine("The elements in the list are:");
		for(int i=0;i<n;i++)
		Console.Write("{0}\t",a[i]);
		Console.WriteLine();
	}
	
}

class ListTest
{
	static void Main()
	{	
		Console.Write("Enter size of the list:");
		int m=int.Parse(Console.ReadLine());
		List l=new List(m);
		l.ReadElements();
		l.Print();
		int e;
		while(true)
		{
			Console.WriteLine("0-Exit\n1-Insert\n2-Delete\n3-Find Element\n4-Sort\n5-Reverse");
			Console.Write("Enter your option:");
			int opt=int.Parse(Console.ReadLine());
			switch(opt)
			{
				case 0:
					Environment.Exit(0);
					break;
				case 1:
					if(l.sz==l.n){
                 Console.WriteLine("List is full, you can't insert");
                 break;
              }
               Console.Write("Enter position to insert:");
					int p=int.Parse(Console.ReadLine());
					if(p<l.sz&&p<=l.n)
					{
						Console.Write("Enter element to insert:");
						e=int.Parse(Console.ReadLine());
						l.Insert(p,e);
						l.Print();
					}
					else
						Console.WriteLine("The list is full");
					break;
				case 2:
					Console.Write("Enter position to delete:");
					l.Delete(int.Parse(Console.ReadLine()));
					Console.WriteLine("After delete:");
					l.Print();
					break;
				case 3:
					Console.Write("Enter element to find in the list:");
					e=int.Parse(Console.ReadLine());
					p=l.FindEle(e);
					if(p!=-1)
						Console.WriteLine("The element found in position {0}",p);
					else
						Console.WriteLine("The element not found");
					break;
				case 4:
						l.SortList();
						Console.WriteLine("The sorted list is:");
						l.Print();
						break;
				case 5:
						l.Reverse();
						Console.WriteLine("The reversed list is:");
						l.Print();
						break;
		
				default :
						Console.WriteLine("Wrong Option");
						break;
			}
		}
	}
}

//Lab02-jaggedArray
using System;
class jagged
{
	public static void Main()
	{
		int [][]a;
		int m;
		Console.WriteLine("Enter the initial value of Jagged array:");
		m = int.Parse(Console.ReadLine());
		a = new int[m][];
		
		for(int i=0;i<m;i++)
		{
			Console.Write("enter value of n:");
			int n=int.Parse(Console.ReadLine());
			Console.WriteLine("enter the values into {0} array:",i);
			a[i]=new int[n];
			for(int j=0;j<n;j++)
				a[i][j]=int.Parse(Console.ReadLine());
			Console.WriteLine();
		}
		Console.WriteLine("Elements are:");
		for(int i=0;i<m;i++)
		{
			for(int j=0;j<a[i].Length;j++)
				Console.Write( a[i][j]+" ");
			Console.WriteLine();
		}
	}
}		


//Lab02-2D-Array
using System;
class Matrix
{
	int r,c;
	int[,] a;
	
	public Matrix(int R=1,int C=1)
	{
		r=R;
		c=C;
		a=new int[r,c];
	}
	
	public void ReadMatrix()
	{
		Console.WriteLine("Enter elememts of matrix:");
		for(int i=0;i<r;i++)
			for(int j=0;j<c;j++)
			{
				Console.Write("a[{0},{1}]=",i,j);
				a[i,j]=int.Parse(Console.ReadLine());
			}
	}
	
	public void PrintMatrix()
	{
		Console.WriteLine("the matrix is:");
		for(int i=0;i<r;i++)
		{
			for(int j=0;j<c;j++)
				Console.Write(a[i,j]+"	");
			Console.WriteLine();
		}
	}
	
	public void Add(Matrix m)
	{
		if(r==m.r&&c==m.c)
		{
			Matrix res=new Matrix(r,c);
			for(int i=0;i<r;i++)
				for(int j=0;j<c;j++)
					res.a[i,j]=a[i,j]+m.a[i,j];
			res.PrintMatrix();
		}
		else
			Console.WriteLine("the matrix addition is not possible");
	}
	
	public void Mul(Matrix m)
	{
		if(c==m.r)
		{
			Matrix res=new Matrix(r,c);
			for(int i=0;i<r;i++)
				for(int j=0;j<m.c;j++)
				{
					res.a[i,j]=0;
					for(int k=0;k<c;k++)
						res.a[i,j]+=a[i,k]*m.a[k,j];
				}
			res.PrintMatrix();
		}
		else
			Console.WriteLine("the matrix multiplication not possible");
	}
}

class MatrixTest
{
	static void Main()
	{	
		Console.Write("Enter size of first matrix:rows&columns:");
		int p=int.Parse(Console.ReadLine());
		int q=int.Parse(Console.ReadLine());
		Matrix m1=new Matrix(p,q);
		m1.ReadMatrix();
		m1.PrintMatrix();
		
		Console.Write("Enter size of 2nd matrix:rows&columns:");
		p=int.Parse(Console.ReadLine());
		q=int.Parse(Console.ReadLine());
		Matrix m2=new Matrix(p,q);
		m2.ReadMatrix();
		m2.PrintMatrix();
		
		Console.WriteLine("the resultant matrix is:");
		m1.Add(m2);
		
		Console.WriteLine("the product matrix is:");
		m1.Mul(m2);
		
		
	}	
}
/*
Output:
Enter size of first matrix rows and columns:2 3
Enter elements of matrix
a[0,0]=1
a[0,1]=2
a[0,2]=3
a[1,0]=4
a[1,1]=5
a[1,2]=6
The matrix is
1 2 3
4 5 6 
Enter size of first matrix rows and columns:2 3
Enter elements of matrix
a[0,0]=5
a[0,1]=6
a[0,2]=7
a[1,0]=8
a[1,1]=9
a[1,2]=1
The matrix is
5 6 7
8 9 1
The sum of matrix is
6     8    10
12   14    7 
The multiplication not possible

*/


//Lab03-StringMethods
using System;
class StringMethodsVc
{
	static void Main()
	{
		string s1,s2,s;
		char[] ca;
		char c;
		string[] str;
		Console.WriteLine("Enter 3 strings");
      Console.Write("enter string s1:");															
		s1=Console.ReadLine();
		Console.Write("enter a string s2(sub string of s1):");
		s2=Console.ReadLine();
		Console.Write("enter string s3:");
		s=Console.ReadLine();
		
      while(true)
		{
			Console.WriteLine();
         Console.WriteLine("0-Exit\n1-s1 contains s2?\n2-s1 ends with s2?");
         Console.WriteLine("3-Entered char in s1-first index?\n4-Entered string in s1-first index?");
         Console.WriteLine("5-Insert string in s1\n6-Entered char in s1-last index?");
         Console.WriteLine("7-Entered string in s1-last index?\n8-Replace string");
         Console.WriteLine("9-Replace char\n10-To Upper Case");
         Console.WriteLine("11-To Lower Case\n12- Trim");
         Console.WriteLine("13-Split String");
         
			Console.Write("Enter your option:");
			int opt=int.Parse(Console.ReadLine());
			switch(opt)
			{
				case 0:
					Environment.Exit(0);
					break;
				case 1:
					if(s1.Contains(s2))
                  Console.WriteLine("{0}  contains {1}",s1,s2);
               else 
                  Console.WriteLine("{0}  not contains {1}",s1,s2);
					break;
				case 2:
					if(s1.EndsWith(s2))
                  Console.WriteLine("{0}  ends with {1}",s1,s2);
              
               else 
                  Console.WriteLine("{0} does not end with {1}",s1,s2);
					break;
				case 3:
					Console.Write("enter char to check in the string"
                  +"\"{0}\" to give first index:",s1);
               c=char.Parse(Console.ReadLine());
               Console.WriteLine("{0} is in the index of "
                  +"{1}",c,s1.IndexOf(c));
					break;
				case 4:
						Console.WriteLine("enter string to check in the"
                     +"string \"{0}\" to give first index:",s1);
                  s=Console.ReadLine();
                  Console.WriteLine("{0} is in the index of"
                     +"{1}",s,s1.IndexOf(s));
						break;
				case 5:
						Console.WriteLine("enter string to insert in"
                     +"the string \"{0}\":",s1);
                  s=Console.ReadLine();
                  Console.Write("enter position to place it:");
                  int p=int.Parse(Console.ReadLine());
                  Console.WriteLine(s1.Insert(p,s));
						break;
            case 6:      
                  Console.WriteLine("enter char to check in the "
                     +"string to give last index in string \"{0}\"",s1);
                  c=char.Parse(Console.ReadLine());
                  Console.WriteLine("{0} is in the index of"
                     +"{1}",c,s1.LastIndexOf(c));
                  break;
            case 7:      
                  Console.WriteLine("enter string to check in "
                     +"the string \"{0}\" to give last index",s1);
                  s=Console.ReadLine();
                  Console.WriteLine("{0} is in the index of "
                     +"{1}",s,s1.LastIndexOf(s));
                  break;
            case 8:      
                  Console.WriteLine("enter two strings, string "
                  +"to be replaced & with which in \"{0}\"",s1);
                  s=Console.ReadLine();
                  s2=Console.ReadLine();
                  Console.WriteLine(s1.Replace(s,s2));
                  break;
            case 9:      
                  Console.WriteLine("enter chars to replace the"
                     +"char with new char in string \"{0}\"",s1);
                  c=char.Parse(Console.ReadLine());
                  char c1=char.Parse(Console.ReadLine());
                  Console.WriteLine(s1.Replace(c,c1));
                  break;
            case 10:      
                  Console.WriteLine("the string in upper case:"
                     +"{0}",s1.ToUpper());
                  break;
            case 11:      
                  Console.WriteLine("the string in lower case:"
                     +"{0}",s1.ToLower());
                  break;
            case 12:      
                  Console.WriteLine("Enter a string with lot of"
                     +"spaces at the front and after");
                  s2=Console.ReadLine();
                  Console.WriteLine("the string before trim is:"
                  +"\n\"{0}\"",s2);
                  Console.WriteLine("the string after trim is:"
                  +"\n\"{0}\"",s2.Trim());
                  break;
            case 13:      
                  Console.WriteLine("Enter a string with few "
                  +"commas, spaces");
                  s=Console.ReadLine();
                  ca=new char[2];
                  ca[0]=' ';
                  ca[1]=',';
                  str=s.Split(ca);
                  for(int i=0;i<str.Length;i++)
                     Console.WriteLine(str[i]); 
                  break;
				default :
						Console.WriteLine("Wrong Option");
						break;
			}
		}
	
	}
}		
//(s1.StartsWith(s))
//ca=s1.ToCharArray();
//s.Substring(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())
		
 /*
		if(s1.StartsWith(s))
			Console.WriteLine("{0} is starts with {1}",s1,s);
		else
			Console.WriteLine("{0} does not starts {1}",s1,s);
			
		
		Console.WriteLine("enter position to start sub string in \"{0}\"",s);
		Console.WriteLine(s.Substring(int.Parse(Console.ReadLine())));
		
		Console.WriteLine("enter position to start sub string and position to end in \"{0}\"",s);
		Console.WriteLine(s.Substring(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
		
		ca=s1.ToCharArray();
		Console.WriteLine("the char in the string \"{0}\" are:",s1);
		for(int i=0;i<ca.Length;i++)
			Console.Write(ca[i]+"   ");
		Console.WriteLine();
		
		Console.WriteLine("Enter position and length to convert char array in \"{0}\":",s1);
		ca=s1.ToCharArray(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
		for(int i=0;i<ca.Length;i++)
			Console.Write(ca[i]+" ");
      
      */


//Lab04-OperatorOverloading
using System;
class Vector
{
	int x,y;
	
	public Vector(int x=0,int y=0)
	{
		this.x=x;
		this.y=y;
	}
	public double GetLength()
	{
		return Math.Sqrt((x*x)+(y*y));
	}
	public static Vector operator +(Vector v,Vector v1)
	{
		Vector t=new Vector();
		t.x=v.x+v1.x;
		t.y=v.y+v1.y;
		return t;
	}
	public static Vector operator -(Vector v,Vector v1)
	{
		Vector t=new Vector();
		t.x=v.x-v1.x;
		t.y=v.y-v1.y;
		return t;
	}
   
	public static Vector operator *(int n,Vector v1)
	{
		Vector t=new Vector();
		t.x=n*v1.x;
		t.y=n*v1.y;
		return t;
	}
	public static Vector operator ++(Vector v)
	{
		Vector t=new Vector();
		t.x=v.x+1;
		t.y=v.y+1;
		return t;
	}
	
	public static bool operator >(Vector v1,Vector v2)
	{
		return v1.GetLength()>v2.GetLength();
	}
	public static bool operator <(Vector v1,Vector v2)
	{
		return v1.GetLength()<v2.GetLength();
	}
	public void Print()
	{
		Console.WriteLine("{0},{1}",x,y);
	}
}

class OverLoadOperatorTest
{
	static void Main()
	{
		Vector v1,v2,v3;
		Console.WriteLine("enter two int values of vector1");
		v1=new Vector(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
		Console.WriteLine("enter two int values of  vector2");
		v2=new Vector(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
		
		v1.Print();
		v2.Print();
		while(true)
		{
			Console.WriteLine();
         Console.WriteLine("0)Exit\t1)Add\t2)Subtract\t3)Multiply\t4) ++\t5) >");
         
			Console.Write("Enter your option:");
			int opt=int.Parse(Console.ReadLine());
			switch(opt)
			{
				case 0:
					Environment.Exit(0);
					break;
				case 1:
					Console.Write("v1:");
               v1.Print();
               Console.Write("v2:");
               v2.Print();
               v3=v1+v2;
               Console.Write("v3:");
               v3.Print();
               break;
				case 2:
					Console.Write("v1:");
               v1.Print();
               Console.Write("v2:");
               v2.Print();
               v3=v1-v2;
               Console.Write("v3:");
               v3.Print();
					break;
				case 3:
					Console.Write("v1:");
               v1.Print();
               Console.Write("enter number to multiply v1:");
               int n=int.Parse(Console.ReadLine());
               v3=n*v1;
               Console.Write("v3:");
               v3.Print();
					break;
				case 4:
					Console.Write("v1:");
               v1.Print();
               v3=++v1;
               Console.Write("v3:");
               v3.Print();
					break;
				case 5:
					Console.Write("v1:");
               v1.Print();
               Console.Write("v2:");
               v2.Print();
               if(v1>v2)
                  Console.WriteLine("v1 is greater than v2");
               else
                  Console.WriteLine("v2 is greater than v1");
					break;
            
            default :
						Console.WriteLine("Wrong Option");
						break;
			}
		}
	}
}


//Lab05-AbstractClass
using System;
abstract class Shape{
   public int l,b,h;
   public double a;
   public abstract void Area();
   public abstract void Display();
}
class TwoDShape : Shape{
      //public TwoDShape(){l=b=h=0;}
      //public TwoDShape(int i, int j){l=i;b=j;}
      public  override void Area(){}
      public  override void Display(){}
}

class Rectangle:TwoDShape{
      //public Rectangle(int i, int j):base(i,j){}
      public override void  Area(){
         Console.Write("Enter Length of Rectangle:");
         l=int.Parse(Console.ReadLine());
         Console.Write("Enter Breadth of Rectangle:");
         b=int.Parse(Console.ReadLine());
         a=l*b;
      }
      public override void  Display(){
         Console.WriteLine("Length="+l+", Breadth="+b+", Area of Rectangle="+a);
      }
}
class Triangle:TwoDShape{
      //public Triangle(int i, int j):base(i,j){}
      public override void  Area(){
         Console.Write("Enter Breadth of Triangle:");
         b=int.Parse(Console.ReadLine());
         Console.Write("Enter Height of Triangle:");
         h=int.Parse(Console.ReadLine());
         a=0.5*b*h;
      }
      public override void  Display(){
         Console.WriteLine("Breadth="+b+", Height="+h+", Area of Triangle="+a);
      }
}
class AbstTest{
   static void Main(){
      Shape o1;
      Rectangle ob1 = new Rectangle();
      Triangle ob2 = new Triangle();
      o1=ob1;
      o1.Area();
      o1.Display();
      o1=ob2;
      o1.Area();
      o1.Display();
   }
}   


//Lab06aFileCopy
//copying file using file stream
using System;
using System.IO;
class CopyFileDemo{
	static void Main(string[] args){
		int i;
		FileStream fin=null;
		FileStream fout=null;
		if(args.Length!=2)
		{
			Console.WriteLine("Usage:CopyFileDemo Copy To");
			return;
		}
		try{
			fin=new FileStream(args[0],FileMode.Open);
			fout=new FileStream(args[1],FileMode.Create);
			do{
				i=fin.ReadByte();
				if(i!=-1){
					fout.WriteByte((byte)i);
				}
			}while(i!=-1);
		}
		catch(IOException exc){
			Console.WriteLine("IOException:"+exc.Message);
		}
		finally{
			if(fin!=null)
				fin.Close();
			if(fout!=null)
				fout.Close();
		}
	}
}

//Lab06b-CharCopy
using System;
using System.IO;
class ChCopy{
	static void Main(string[] args){
		string s;
		if(args.Length!=2){
			Console.WriteLine("USAGE:FROM TO");
			return;
		}
		StreamReader fin=new StreamReader(args[0]);
		StreamWriter fout=new StreamWriter(args[1]);
		try{
			
			while((s=fin.ReadLine())!=null){
				fout.Write(s+"\n");
			}
		}
		catch(IOException exc){
			Console.WriteLine("IO Error:"+exc.Message);
		}
		finally{
			if(fin!=null){fin.Close();}
			if(fout!=null){fout.Close();}
		}
	}
}

//Lab07ExcptionHandling
using System;
class StackOverFlowException:Exception{
	public Stack sa;
	public StackOverFlowException(Stack s):base("Stack OverFlow"){
		sa=s;
	}
}
class StackUnderFlowException:Exception{
	public Stack sa;
	public StackUnderFlowException(Stack s):base("Stack UnderFlow"){
		sa=s;
	}
}
class Stack{
	int[] a;
	int sz;
	int top;
	public Stack(int n){
		a=new int[sz=n];
		top=0;
	}
	bool IsFull(){
		return sz==top;
	}
	bool IsEmpty(){
		return top==0;
	}
	public void Push(int e){
		if(IsFull())
			throw new StackOverFlowException(this);
		a[top++]=e;
	}
	public int Pop(){
		if(IsEmpty())
			throw new StackUnderFlowException(this);
		return a[--top];
	}
}
class StackDemo{
	static void Main(){
		Stack s=new Stack(5);
		
         for(int i=0;i<5;i++)
            s.Push(i);
         Console.Write("The elements Pushed into the Stack are:   ");
         for(int i=0;i<5;i++)
            Console.Write(s.Pop()+" ");
         Console.Write("\n");
			Console.WriteLine("If we try to push 6th element:");
         try{
            for(int i=0;i<6;i++)
               s.Push(i);
         }
			catch(StackOverFlowException e){
				Console.WriteLine(e.Message);
			}
         Console.WriteLine("If we try to pop 6th element:");
         try{
            for(int i=0;i<6;i++)
               s.Pop();
			}
			catch(StackUnderFlowException e){
				Console.WriteLine(e.Message);
			}
	}
}
/*
The elements Pushed into the Stack are:   4 3 2 1 0
If we try to push 6th element:
Stack OverFlow
If we try to pop 6th element:
Stack UnderFlow
*/


//Lab08-EventDemo
using System;
using System.Threading;
delegate void TickEventHandler();
class Clock
{
	public static event TickEventHandler th;
	public void Run()
	{
		while(true)
		{
			Thread.Sleep(2000);//2 seconds
			if(th!=null)
				th();
		}
	}
}
class A
{
	public A()
	{
		Clock.th+=TickHandlerA;
	}
	public void TickHandlerA()
	{
		Console.WriteLine("Tick Event Response from Class A");
	}
}
class B
{
	public B()
	{
		Clock.th+=TickHandlerB;
	}
	public void TickHandlerB()
	{
		Console.WriteLine("Tick Event Response from Class B");
	}
}
class EventDemo
{
	static void Main()
	{
		Clock c=new Clock();
		A o=new A();
		B b=new B();
		c.Run();
	}
}
/*Output:
Tick Event Responce from Class A
Tick Event Responce from Class B
Tick Event Responce from Class A
Tick Event Responce from Class B*/

//Lab09-GenericDemo
using System;
public interface IA <T>
{
	void Write();
}
class Test<T>:IA <T>
{
    T value;

    public Test(T t)
    {
	// The field has the same type as the parameter.
		value = t;
    }

    public void Write()
    {
		Console.WriteLine(value);
    }
}
class Calculator
{
	public static bool AreEqual <T>(T value1,T value2)
	{
		return value1.Equals(value2);
	}
}	

class GenericDemo
{
    static void Main()
    {
		// Use the generic type Test with an int type parameter.
		Test<int> test1 = new Test<int>(5);
		// Call the Write method.
		test1.Write();

		// Use the generic type Test with a string type parameter.
		Test<string> test2 = new Test<string>("cat");
		test2.Write();
		bool Equal=Calculator.AreEqual<int>(1,1);
		if(Equal)
		{
			Console.WriteLine("Equal");
		}
		else
		{
			Console.WriteLine("Not Equal");	
		}
		
		bool Equal1=Calculator.AreEqual<string>("A","B");
		if(Equal1)
		{
			Console.WriteLine("Equal");
		}
		else
		{
			Console.WriteLine("Not Equal");	
		}
    }
}


//Lab09-GenericInterfaceDemo
using System;
public interface IA <T>
{
	void Write();
}
class Test<T>:IA <T>
{
    T value;

    public Test(T t)
    {
	// The field has the same type as the parameter.
		value = t;
    }

    public void Write()
    {
		Console.WriteLine(value);
    }
}
class Calculator
{
	public static bool AreEqual <T>(T value1,T value2)
	{
		return value1.Equals(value2);
	}
}	

class InterfaceDemo
{
    static void Main()
    {
		// Use the generic type Test with an int type parameter.
		Test<int> test1 = new Test<int>(5);
		// Call the Write method.
		test1.Write();

		// Use the generic type Test with a string type parameter.
		Test<string> test2 = new Test<string>("cat");
		test2.Write();
		bool Equal=Calculator.AreEqual<int>(1,1);
		if(Equal)
		{
			Console.WriteLine("Equal");
		}
		else
		{
			Console.WriteLine("Not Equal");	
		}
		
		bool Equal1=Calculator.AreEqual<string>("A","B");
		if(Equal1)
		{
			Console.WriteLine("Equal");
		}
		else
		{
			Console.WriteLine("Not Equal");	
		}
    }
}

//Lab10-ArryList
/*Array List Demo*/
using System;
using System.Collections;
class ArrayListDemo
{ 
	static void Print(ArrayList Countries) 
	{ 
		for(int i=0;i<Countries.Count;i++)
		Console.Write(Countries[i]+" "); 
		Console.WriteLine();
	} 
	static void Main()
	{ 
		ArrayList Countries=new ArrayList(); 
		Countries.Add("India");
		Countries.Add("Indonesia");
		Countries.Add("Argentina"); 
		Countries.Add("FinLand"); 
		Countries.Add("Kenya");
		Countries.Add("Brazil");
		Countries.Add("Bangladesh");
		Countries.Add("NewZealand"); 
		Countries.Add("England"); 
		Countries.Add("Srilanka"); 
		Countries.Add("Pakistan"); 
		Print(Countries); 
		foreach(String c in Countries) 
		Console.Write(c+" "); 
		Console.WriteLine(); 
		IEnumerator en=Countries.GetEnumerator(); 
		while(en.MoveNext()) 
         Console.Write(en.Current+" "); 
		Console.WriteLine(); 
		Countries.RemoveAt(1); 
		//Countries.Remove("France"); 
		Countries.Insert(0,"America"); 
		for(int i=0;i<Countries.Count;i++) 
         Console.Write(Countries[i]+" "); 
		Console.WriteLine(); 
		if(Countries.Contains("Brazil")) 
         Console.WriteLine("Brazil is Present"); 
		int k=Countries.IndexOf("England"); 
		Console.WriteLine("England is present at "+k); 
		Countries.Sort(); 
		Print(Countries); 
		k=Countries.BinarySearch("England"); 
		Console.WriteLine("England is Present at "+k); 
		Countries.Reverse(); 
		Print(Countries); 
		ArrayList clist=Countries.GetRange(2,5); 
		Print(clist); 
		String[] someCountries=new String[4]; 
		Countries.CopyTo(2,someCountries,0,4); 
		for(int i=0;i<someCountries.Length;i++) 
         Console.Write(someCountries[i]+" "); 
		Console.WriteLine(); 
		Countries.RemoveRange(0,5); 
		Print(Countries); 
	}
}

/*Output:

India Indonesia Argentina FinLand Kenya Brazil Bangladesh NewZealand England Srilanka Pakistan

India Indonesia Argentina FinLand Kenya Brazil Bangladesh NewZealand England Srilanka Pakistan

India Indonesia Argentina FinLand Kenya Brazil Bangladesh NewZealand England Srilanka Pakistan

America India Indonesia Argentina FinLand Kenya Brazil Bangladesh NewZealand England Srilanka 

Pakistan

Brazil is present

England is present at 8

America Argentina Bangladesh Brazil England FinLand India Kenya NewZealand Pakistan Srilanka

England is present at 4

Srilanka Pakistan NewZealand Kenya India FinLand England Brazil Bangladesh Argentina America

NewZealand Kenya India FinLand England

Srilanka Pakistan NewZealand Kenya

FinLand England Brazil Bangladesh Argentina America*/
	  

