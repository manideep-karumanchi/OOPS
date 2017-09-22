using System;
class RangingArray{
	private int[] a;
	private int length;
	private bool errFlag;
	int lowerBound,upperBound;
	public int Length{
		get{
			return length;
		}
	}
	public bool ErrFlag{
		get{
			return errFlag;
		}
	}
	public RangingArray(int lb,int ub){
		upperBound=ub;
		lowerBound=lb;
		a=new int[(ub+1)-lb];
		length=(ub+1)-lb;
	}
	public int this[int index]{
		get{
			if(ok(index)){
				errFlag=false;
				return a[index-lowerBound];
			}
			else{
				errFlag=true;
				return -1;
			}
		}
		set{
			if(ok(index)){
				errFlag=false;
				a[index-lowerBound]=value;
			}
			else{
				errFlag=true;
			}
		}
	}
	bool ok(int index){
		return (index>=lowerBound&&index<=upperBound);
	}
}