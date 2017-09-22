using System;
class MFSA{
	public int[,] a;
	int rows,cols;
	public int length;
	public bool errFlag;
	public MFSA(int r,int c){
		a=new int[r,c];
		rows=r;cols=c;
		length=r*c;
	}
	public int this[int ri,int ci]{
		get{
			if(ok(ri,ci)){
				errFlag=false;
				return a[ri,ci];
			}
			else{
				errFlag=true;
				return -1;
			}
		}
		set{
			if(ok(ri,ci)){
				errFlag=false;
				a[ri,ci]=value;
			}
			else{
				errFlag=true;
			}
		}
	}
	bool ok(int ri,int ci){
		return (ri>=0&&ri<rows&&ci>=0&&ci<cols);
	}
}
class FSATest{
	static void Main(){
		MFSA f=new MFSA(5,3);
		for(int i=0;i<6;i++)
			f[i,i]=i*i;
		for(int i=0;i<6;i++)
			Console.WriteLine(f[i,i]);
			
		for(int i=0;i<6;i++){
			f[i,i]=i*i;
			if(f.errFlag)
				Console.WriteLine("Index Out of Bounds"+i+","+i);
		}
			
		for(int i=0;i<6;i++)
			if(f[i,i]!=-1)Console.WriteLine(f[i,i]);
			else Console.WriteLine("Index Out of Bounds"+i+","+i);
	}
}