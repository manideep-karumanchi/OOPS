using System;
abstract class BankAccount{
	public String accNo,branch;
	public double ir;
	public decimal bal;
	public BankAccount(){
		accNo="";
		branch="";
		ir=0.0;
		bal=0.0m;
	}
	public BankAccount(String ano,String br,double i,decimal b){
		accNo=ano;
		branch=br;
		ir=i;
		bal=b;
	}
	abstract public decimal Withdraw(decimal amt);
	public void Deposit(decimal amt){
		bal=bal+amt;
	}
	public virtual String GetType(){
		return "Bank Account";
	}
}
class SBAccount:BankAccount{
	public String accHolderName,accHolderAddress;
	public decimal minBal;
	public SBAccount(String ano,String br,double i,decimal b,String an,String aa,decimal mb):base(ano,br,i,b){
		accHolderName=an;
		accHolderAddress=aa;
		minBal=mb;
	}
	
	sealed public override decimal Withdraw(decimal amt){
		if(bal-amt>=minBal){
			bal-=amt;
			return bal;
		}
		return -1;
	}
	public virtual String GetType(){
		return "Savings Bank Account";
	}
}
/*class test:SBAccount{
	public override decimal Withdraw(decimal amt){
		if(bal-amt>=minBal){
			bal-=amt;
			return bal;
		}
		return -1;
	}
}*/
class CBAccount:BankAccount{
	public String accOrgName,accOrgAddress;
	public decimal overdrawLimit;
	public CBAccount(String ano,String br,double i,decimal b,String an,String aa,decimal ol):base(ano,br,i,b){
		accOrgName=an;
		accOrgAddress=aa;
		overdrawLimit=ol;
	}
	public override decimal Withdraw(decimal amt){
		if(bal-amt>=overdrawLimit){
			bal-=amt;
			return bal;
		}
		return -1;
	}
	public virtual String GetType(){
		return "Current Bank Account";
	}
}
class BankAccountsDemo{
	static void Main(){
		//BankAccount o=new BankAccount();
		//o.Withdraw(1000.0m);
		BankAccount sb=new SBAccount("12345667890","SBI BEC",4.0,5000.0m,"asdfghjkl","zxcvbnm",500.0m);
		if(sb.Withdraw(500)!=-1)
			Console.WriteLine("Balance after Withdraw:"+sb.bal);
		else
			Console.WriteLine("Insuuficiant funds");
		if(sb.Withdraw(6700)!=-1)
			Console.WriteLine("Balance after Withdraw:"+sb.bal);
		else
			Console.WriteLine("Insuuficiant funds");
		BankAccount cb=new CBAccount("12345667890","SBI BEC",4.0,5000.0m,"asdfghjkl","zxcvbnm",500.0m);
		cb.Deposit(1000m);
		if(cb.Withdraw(500)!=-1)
			Console.WriteLine("Balance after Withdraw:"+cb.bal);
		else
			Console.WriteLine("Insuuficiant funds");
		if(cb.Withdraw(6700)!=-1)
			Console.WriteLine("Balance after Withdraw:"+cb.bal);
		else
			Console.WriteLine("Insuuficiant funds");
		
		
	}
}