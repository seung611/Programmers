using System;

public class Solution {
    public int solution(int[] array) {
        string n = string.Join("", array);
        int answer = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == '7')
            {
                answer++;
            }
        }
        return answer;
    }
}