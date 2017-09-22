class test{
	static int a=5;
}
class TestDemo{
	public static void main(String[] args){
		test t=new test();
		test t1=new test();
		test t2=new test();
		t.a=10;
		System.out.println("t.a="+t.a);
		System.out.println("t1.a="+t1.a);
		System.out.println("t2.a="+t2.a);
	}
}
