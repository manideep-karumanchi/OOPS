using System;
class EnumEx{
	enum grades{O,AP,A,BP,B,C,F};
	static void FindGrade(int marks){
		if(marks>=90)
			Console.WriteLine((int)grades.O);
		else if(marks>=80)
			Console.WriteLine(grades.AP);
		else if(marks>=70)
			Console.WriteLine(grades.A);
		else if(marks>=60)
			Console.WriteLine(grades.BP);
		else if(marks>=50)
			Console.WriteLine(grades.B);
		else if(marks>=40)
			Console.WriteLine(grades.C);
		else{
			int g=(int)grades.F;
			Console.WriteLine((grades)3);
		}
	}
	static void Main(){
		FindGrade(90);
		FindGrade(20);
	}
}