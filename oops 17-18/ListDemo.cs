using System;
class List{
	int[] list;
	public int size,n;
	public List(int size){
		list = new int[size];
		this.size=size;
		n=0;
	}
	public void ReadElements(int n){
		this.n=n;
		for(int i=0;i<n;i++){
			Console.WriteLine("Enter value of List["+i+"]:");
			list[i]=int.Parse(Console.ReadLine());
		}
	}
	public void Insert(int element,int position){
		for(int i=n-1;i>position;i--){
			list[i+1]=list[i];
		}
		list[position]=element;
		n++;
	}
	public void Delete(int position){
		for(int i=position;i<n-1;i++){
			list[i]=list[i+1];
		}
		n--;
	}
	public void Print(){
		for(int i=0;i<n;i++){
			Console.Write(list[i]+"\t");
		}
		Console.WriteLine();
	}
	public void Sort(){
		for(int i=0;i<n-1;i++){
			for(int j=i+1;j<n;j++){
				if(list[i]>list[j]){
					Swap(i,j);
				}
			}
		}
	}
	
	public void Reverse(){
		for(int i=0,j=n-1;i<=j;i++,j--){
			Swap(i,j);
		}
	}
	public void Min(){
		int[] temp=new int[size];
		for(int i=0;i<n;i++){
			temp[i]=list[i];
		}
		Sort();
		Console.WriteLine("Minimum Element is:"+list[0]);
		list=temp;
	}
	void Swap(int i,int j){
		int temp=list[i];
		list[i]=list[j];
		list[j]=temp;
	}
}

class ListDemo{
	static void Main(){
		Console.WriteLine("Enter the Size of the list");
		int size=int.Parse(Console.ReadLine());
		List l = new List(size);
		int n;
		do{
			Console.WriteLine("Enter No of Elements:");
			n=int.Parse(Console.ReadLine());
		}while(n>size);
		l.ReadElements(n);
		l.Print();
		int position;
		do{
			Console.WriteLine("Enter position to insert(value between 0 and "+l.n+"):");
			position=int.Parse(Console.ReadLine());
		}while(position<0 || position > l.n);
		Console.WriteLine("Enter element to insert:");
		int ele=int.Parse(Console.ReadLine());
		l.Insert(ele,position);
		Console.WriteLine("List after insert");
		l.Print();
		do{
			Console.WriteLine("Enter position to delete(value between 0 and "+(l.n-1)+"):");
			position=int.Parse(Console.ReadLine());
		}while(position<0 || position >= l.n);
		l.Delete(position);
		Console.WriteLine("List after delete");
		l.Print();
		
		l.Sort();
		Console.WriteLine("List after sort");
		l.Print();
		
		l.Reverse();
		Console.WriteLine("List after reverse");
		l.Print();
		l.Min();
		Console.WriteLine("List after Min");
		l.Print();
	}
}