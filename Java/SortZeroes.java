// https://practice.geeksforgeeks.org/problems/sort-an-array-of-0s-1s-and-2s4231/1?page=1&company[]=Microsoft&curated[]=1&sortBy=submissions

public class SortZeroes {
    public static void main (String[] args){
        sort012(new int[] {0, 2, 1, 2, 0} , 5);
    }

    public static void sort012(int a[], int n)
    {
        var zeroes = 0;
        var ones = 0;
        var twos = 0;

        for (int i = 0; i < n ; i++) {
            switch (a[i]) {
                case 0:
                    zeroes ++;
                    break;
                case 1:
                    ones++;
                    break;
                case 2:
                    twos ++;
                    break;
            }
        }

        for (int i = 0; i < zeroes ; i++) {
            a[i] = 0;
        }

        for (int i = zeroes; i < zeroes + ones ; i++) {
            a[i] = 1;
        }
        
        for (int i = zeroes + ones; i < zeroes + ones + twos ; i++) {
            a[i] = 2;
        }

        System.out.print(a);
        
    } 
}
