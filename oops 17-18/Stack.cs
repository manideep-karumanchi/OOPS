using System;
class Stack{
	int tos;
	int[] _stack;
	int size;
	
	public Stack(int size=10){
		_stack=new int[size];
		tos=0;
		this.size=size;
	}
	public void Push(int ele){
		if(IsFull()){
			Console.WriteLine("Stack Overflow");
			return;
		}
		_stack[tos]=ele;
		tos++;
	}
	public int Pop(){
		if(tos==0){
			Console.WriteLine("Stack Underflow");
			return -1;
		}
		tos--;
		return _stack[tos];
	}
	public void Copy(Stack s1){
		_stack=new int[s1._stack.Length];
		for(int i=0;i<s1._stack.Length;i++){
			_stack[i]=s1._stack[i];
		}
		tos=s1.tos;
	}
	public void Print(){
		Console.WriteLine("Stack Contents");
		for(int i=0;i<tos;i++){
			Console.Write(_stack[i]);
		}
		Console.WriteLine();
	}
	public bool IsFull(){
		return tos==size;
	}
}
class StackDemo{
	static void Main(){
		Stack s=new Stack();
		Stack s1=new Stack(5);
		Console.WriteLine("Stack 1");
		for(int i=0;i<10;i++){
			s.Push(i+1);
		}
		s.Print();
		for(int i=0;i<10;i++){
			Console.WriteLine("Current Element is"+s.Pop());
		}
		Console.WriteLine("Stack 2");
		for(int i=0;i<5;i++){
			s1.Push((i+1)*3);
		}
		s1.Print();
		Console.WriteLine("Stack 1 size={0} and tos={1}",s.size,s.tos);
		Console.WriteLine("Stack 2 size={0} and tos={1}",s1.size,s1.tos);
		s.Copy(s1);
		s.Print();
		Console.WriteLine("Stack 1 size={0} and tos={1}",s.size,s.tos);
		Console.WriteLine("Stack 2 size={0} and tos={1}",s1.size,s1.tos);
	}
}