using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
	public class Question1
	{
		public Question1()
		{
		}

		//Given an array of integers, determine whether or not there 
		//exist two elements in the array (at different positions) 
		//whose sum is equal to some target value. Examples: [5, 4, 2, 4], 8 --> true [5, 1, 2, 4], 8 
		public bool BruteForce (int[] input, int target)
		{
			int length = input.Length;
			int x, y;
			bool found = false;

			for (x = 0; x < length; x++) {
				for (y = x + 1; y < length- 1; y ++) {
					if (input[x] + input[y + 1] == target)
					{
						found = true;
						break;
					}
				}
				if (found)
					break;
			}
			return found;
		}

        public bool SortMethod(int[] input, int target)
        {
            int left = 0, right = 0;
            bool found = false;
            List<int> inputList = new List<int>();
            inputList.AddRange(input);
            inputList.Sort();
            
            int[] sortedInput = inputList.ToArray();

            right = inputList.Count -1 ;
            while(left < right)
            {
                int sum = sortedInput[left] + sortedInput[right];
                if(sum == target)
                {
                    found = true;
                    break;
                }else if(sum < target)
                {
                    left ++;
                }
                else{
                    right --;
                }
            }

                return found;
        }

        public bool HashMethod(int[] input, int target)
        {
            HashSet<int> values = new HashSet<int>();

            foreach(int num in input)
            {
                if (values.Contains(target - num))
                    return true;
                values.Add(num);
            }

            return false;
        }
	}
}

