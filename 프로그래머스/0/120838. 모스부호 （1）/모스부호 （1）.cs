using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] mos = { ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..",
            "--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        foreach(string a in letter.Split(" "))
        {
            answer += Convert.ToChar(Array.IndexOf(mos, a) + 97);
        }
        return answer;
    }
}