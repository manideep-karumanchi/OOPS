using System;
class StackOverFlowException:Exception{
	public StackOverFlowException(String message):base(message){
	}
}
class StackUnderFlowException:Exception{
	public StackUnderFlowException(String message):base(message){
	}
}
class _Stack{
	int[] stk;
	int tos;
	public _Stack(){
		stk=new int[10];
		tos=-1;
	}
	public _Stack(int size){
		stk=new int[size];
		tos=-1;
	}
	public void Push(int ele){
		if(tos<stk.Length-1){
			tos++;
			stk[tos]=ele;
		}
		else{
			throw new StackOverFlowException("Stack Over Flow");
		}
	}
	public int Pop(){
		if(tos>=0){
			int ele=stk[tos];
			tos--;
			return ele;
		}
		else{
			throw new StackUnderFlowException("Stack Under Flow");
		}
	}
	public void Print(){
		for(int i=tos;i>=0;i--)
			Console.Write(stk[i]+"\t");
		Console.WriteLine();
	}
}
class StackDemo{
	static void Main(){
		_Stack s=new _Stack(5);
		try{
		s.Push(1);
		s.Push(2);
		s.Push(3);
		s.Push(4);
		s.Push(5);
		s.Push(6);
		}catch(StackOverFlowException exe){
			Console.WriteLine(exe.Message);
		}
		try{
		s.Print();
		s.Pop();
		s.Pop();
		s.Pop();
		s.Pop();
		s.Pop();
		s.Pop();
		}catch(StackUnderFlowException exe){
			Console.WriteLine(exe.Message);
		}
		s.Print();
	}
}