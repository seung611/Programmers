using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        string str = order.ToString();
        for (int i = 0; i < str.Length; i++){
            if (str[i] == '3' || str[i] == '6' || str[i] == '9'){
                answer++;
            }
        }
        return answer;
    }
}