using System;
class FSA{
	public int[] a;
	public int length;
	public bool errFlag;
	public FSA(int size){
		a=new int[size];
		length=size;
	}
	public int this[int index]{
		get{
			if(ok(index)){
				errFlag=false;
				return a[index];
			}
			else{
				errFlag=true;
				return -1;
			}
		}
		set{
			if(ok(index)){
				errFlag=false;
				a[index]=value;
			}
			else{
				errFlag=true;
			}
		}
	}
	bool ok(int index){
		return (index>=0&&index<length);
	}
}
class FSATest{
	static void Main(){
		FSA f=new FSA(5);
		for(int i=0;i<f.length*2;i++)
			if(!f.errFlag)f[i]=i+1;
		for(int i=0;i<f.length*2;i++)
			if(f[i]!=-1)Console.WriteLine(f[i]);
			
		for(int i=0;i<f.length*2;i++){
			f[i]=i+1;
			if(f.errFlag)
				Console.WriteLine("Index Out of Bounds"+i);
		}
			
		for(int i=0;i<f.length*2;i++)
			if(f[i]!=-1)Console.WriteLine(f[i]);
			else Console.WriteLine("Index Out of Bounds");
	}
}