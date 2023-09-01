public class Solution {
    public int[] CountBits(int n) {
        List<int> result = new List<int>();
        result.Add(0);

        for(int i = 1; i <= n; i++) {
            int istring = Convert.ToString(i, 2).Replace("0", "").Length;
            result.Add(istring);
        }
          
        return result.ToArray();
    }
}