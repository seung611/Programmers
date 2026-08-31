using System;

public class Solution {
    public int solution(int[] array) {
        Array.Sort(array);
        int num = array.Length / 2;
        return array[num];
    }
}