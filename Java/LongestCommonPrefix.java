public class LongestCommonPrefix {

    public static void main (String[] args){
        String str = longestCommonPrefix(new String[] { "gee",
        "geeksforgeeks",
        "geeks",
        "ge",
        "geek",
        "geezer"
        }, 5);

        System.out.println(str);
    }

    static String longestCommonPrefix(String arr[], int n){
        int index = 0;
        String firstString = arr[0];

        while (true) {
            if (index == firstString.length())
                break;

            Boolean noMatch = false;

            for (int i = 1; i < n; i++)
                {
                    if ((arr[i].length() == index) || (firstString.charAt(index) != arr[i].charAt(index)))
                    {
                        noMatch = true;
                        break;
                    }
                }

                if (noMatch) break;
                index++;
        }

        if (index == 0) return "-1";

        return firstString.substring(0, index );
    }
}
