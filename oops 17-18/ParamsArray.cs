using System;
class ParamsArray{
	static int FindMin(params int[] nums){
		if(nums.Length>=2){
			int min=nums[0];
			for(int i=0;i<nums.Length;i++){
				if(min>nums[i])
					min=nums[i];
			}
			return min;
		}
		else{
			return -1;
		}
	}
	static void Main(){
		int min=FindMin();
		Console.WriteLine("Minimum Value is:"+min);
		min=FindMin(10,20);
		Console.WriteLine("Minimum Value is:"+min);
		min=FindMin(10,20,40);
		Console.WriteLine("Minimum Value is:"+min);
		min=FindMin(10,20,40,30);
		Console.WriteLine("Minimum Value is:"+min);
		min=FindMin(new int[]{1,5,2,7,4,8,9,10,20});
		Console.WriteLine("Minimum Value is:"+min);
	}
}