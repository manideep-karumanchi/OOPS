using System;
struct Book{
	public String name,author;
	public int price;
	public Book(String n,String a,int p){
		name=n;
		author=a;
		price=p;
	}
	public void Show(){
		Console.WriteLine("Title:{0},Author{1},Price:{2}",name,author,price);
	}
}
class Demo{
	static void Main(){
		Book b=new Book("C# 4.0 - The Complete Reference","Herbert Schieldt",400);
		b.Show();
		Book b1=new Book();
		b1.Show();
	}
}