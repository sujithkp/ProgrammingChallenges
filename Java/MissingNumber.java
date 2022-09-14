
//https://practice.geeksforgeeks.org/problems/missing-number-in-array1416/1?page=1&company[]=Microsoft&curated[]=1&sortBy=submissions

public class MissingNumber {
    static int FindMissingNumber(int array[], int n) {
        var sum = (n * (n + 1))/2;

        for (int i = 0; i < n -1 ; i++) {
            sum -= array[i];
        }

        return sum;
    }
}
