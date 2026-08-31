using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        int max = 0;
        int maxNum = 0;
        
        answer[0] = (numer1 * denom2) + (numer2 * denom1);
        answer[1] = denom1 * denom2;
        
        max = answer[0];
        
        for(int i = 1; i <= max; i++)
        {
            if(answer[0] % i == 0 && answer[1] % i == 0)
            {
                maxNum = i;
            }
        }
        
        answer[0] = answer[0] / maxNum;
        answer[1] = answer[1] / maxNum;
        return answer;
    }
}