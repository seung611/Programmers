using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        int lastIndex = numbers.Length - 1;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (direction == "right")
            {
                if (i == 0)
                {
                    answer[0] = numbers[lastIndex];
                    answer[1] = numbers[0];
                }
                else
                {
                    answer[i+1] = numbers[i];
                }
            }
            else
            {
                if (i == 0)
                {
                    answer[0] = numbers[1];
                    answer[lastIndex-1] = numbers[lastIndex];
                    answer[lastIndex] = numbers[0];
                }
                else
                {
                    answer[i-1] = numbers[i];
                }
            }
        }
        return answer;
    }
}