using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        for (int i = 1; i < cipher.Length/code + 1; i++)
        {
            answer += cipher[i * code - 1];
        }
        return answer;
    }
}