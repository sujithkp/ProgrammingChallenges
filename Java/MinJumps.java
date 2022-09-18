import java.io.Console;

public class MinJumps {
    public static void main (String[] args) {
        //int  c =  minJumps(new int[] { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9} );
        //int c =  minJumps(new int[] { 1, 4, 3, 2, 6, 7} );
        int c =  minJumps(new int[] { 2, 3, 1, 1, 2, 4, 2, 0, 1, 1} );
        //int c =  minJumps(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} );
        

        System.out.println(c);
    }

    static int minJumps(int[] arr){

        int currIndex = 0;
        int jumps = 0;

        int nextjumpLength = arr[0];

        if (arr.length == 0) return -1;

        while (currIndex < arr.length - 1) {
            if(currIndex + nextjumpLength >= arr.length - 1) {
                jumps++;
                break;
            }

            currIndex += nextjumpLength;
            nextjumpLength = arr[currIndex];
            jumps++;
        }
        return jumps;
    }
}
