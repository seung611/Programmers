using System;

public class Solution {
    public int solution(int num, int k) {
        string n = num.ToString();
        string _k = k.ToString();
        int index = n.IndexOf(_k) + 1;
        int answer = 0;
        if (index > 0)
        {
            answer = index;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}