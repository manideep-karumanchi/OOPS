using System;
class Stack{
	int tos;
	int[] _stack;
	int size;
	
	public int Tos{
		get{
			return tos;
		}
	}
	public int Size{
		get{
			return size;
		}
	}
	
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
	public bool IsFull(){
		return tos==size;
	}
}
class StackDemo{
	static void Main(){
		Stack s=new Stack();
		for(int i=0;i<s.Size;i++)
			s.Push(i+1);
		//s.Size=14;
		for(int i=0;i<s.Size;i++)
			Console.WriteLine(s.Pop());
		
	}
}