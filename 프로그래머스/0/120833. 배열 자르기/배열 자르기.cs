using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        num2 += 1;
        int[] answer = numbers[num1..num2]; 
        return answer;
    }
}