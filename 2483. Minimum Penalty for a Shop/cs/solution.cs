public class Solution {
    public int BestClosingTime(string customers) {
        int pen = 0;
        int minPen = 0;
        int idx = 0;

        for(int i = 0; i < customers.Length; i++) {
            char s = customers[i];
            if (s == 'Y') pen--;
            if (s == 'N') pen++;

            if (pen < minPen) {
                idx = i + 1;
                minPen = pen;
            }
        }

        return idx;
    }
}