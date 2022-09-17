public class MinJumps {
    public static void main (String[] args) {
        //int  c =  minJumps(new int[] { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9} );
       // int c =  minJumps(new int[] { 1, 4, 3, 2, 6, 7} );
        int c =  minJumps(new int[] { 2, 3, 1, 1, 2, 4, 2, 0, 1, 1} );

        System.out.println(c);
    }

    static int minJumps(int[] arr){

        int currIndex = 0;
        int jumps = 0;
        int nextIndex = 0;

        if (arr.length == 0) return -1;

        while (true) {

            currIndex = nextIndex;

            int elementAtCurrIndex = arr[currIndex];

            nextIndex = currIndex + elementAtCurrIndex;

            if (nextIndex >= arr.length -1  )
            {
                jumps++;
                break;
            }

            jumps ++;
        }

        return jumps;
    }
}
