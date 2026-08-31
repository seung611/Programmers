using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach (char str in my_string){
            answer += char.IsUpper(str) ? char.ToLower(str) : char.ToUpper(str);
        }
        return answer;
    }
}