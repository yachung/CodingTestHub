using System;

public class Solution {
    int answer = 0;
    
    public int solution(int[] numbers, int target)
        {

            dfs(numbers, target, 0, 0);

            return answer;
        }

        public void dfs(int[] numbers, int target, int currentSum, int index)
        {
            if (index == numbers.Length)
            {
                if (currentSum == target)
                    answer++;
                
                return;
            }

            dfs(numbers, target, currentSum + numbers[index], index+1);
            dfs(numbers, target, currentSum - numbers[index], index+1);
        }
}