using System;
class Student{
	String regdno,name,branch,section;
	public String this[int index,int index1]{
		get{
			if(index==0)
				return regdno;
			else if(index==1)
				return name; 
			else if(index==2)
				return branch;
			else if(index==3)
				return section;
			return "Invalid index";
		}
		set{
			if(index==0)
				regdno=value;
			else if(index==1)
				name=value; 
			else if(index==2)
				branch=value;
			else if(index==3)
				section=value;
		}
	}
	public String this[string index]{
		get{
			if(index=="regdno")
				return regdno;
			else if(index=="name")
				return name; 
			else if(index=="branch")
				return branch;
			else if(index=="section")
				return section;
			return "Invalid index";
		}
		set{
			if(index=="regdno")
				regdno=value;
			else if(index=="name")
				name=value; 
			else if(index=="branch")
				branch=value;
			else if(index=="section")
				section=value;
		}
	}
}
class StudentTest{
	static void Main(){
		Student s=new Student();
		s[0]="Y10ACS401";
		s["name"]="asdfgh";
		s[2]="CSE";
		s["section"]="A";
		Console.WriteLine(s["regdno"]+","+s[1]+","+s["branch"]+","+s[3]);
	}
}