import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class ZeroSumSubArray {
    public static void main (String[] args) {
        //int  c=  maxLen(new int[] { 15, -2, 2, -8, 1, 7, 10, 23 } , 8);

        int c = findSubarray(new int[] {  0, 0, 5, 5, 0, 0 }, 6 );

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


    public static int findSubarray(int[] arr ,int n) 
    {
        int sum = 0;
        int count = 0;

        HashMap<Integer, ArrayList<Integer>> map = new HashMap<Integer, ArrayList<Integer>>();

        for (int i = 0; i < n; i++) {

            sum += arr[i];

            if (sum == 0) count++;

            if (map.keySet().contains(sum)) 
                count += ((ArrayList<Integer>)map.get(sum)).size();
            else
                map.put(sum, new ArrayList<>());


            map.get(sum).add(i + 1);
        }

        return count;
    }

}
