import java.util.HashMap;

public class ZeroSumSubArray {
    public static void main (String[] args) {
        int  c=  maxLen(new int[] { 15, -2, 2, -8, 1, 7, 10, 23 } , 8);

        System.out.println(c);
    }

    static int maxLen(int arr[], int n) {
        var sum = 0;
        var count = 0;

        HashMap map = new HashMap<>();

        for (int i = 0; i < n; i++) {
            sum += arr[i];

            if (sum == 0) count = i;

            if(!map.containsKey(sum))
                map.put(sum, i);
            else
                count = Math.max(i - (int)map.get(sum), count);
        }
        return count;
    }

}
