class Result
{

    /*
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string superReducedString(string s)
    {
        char lastChar = (char)0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == lastChar)
            {
                s = s.Remove(i - 1, 2);

                i = i - 2;

                lastChar = (i < 0) ? (char)0 : s[i];

                continue;
            }

            lastChar = s[i];
        }

        return (s.Length == 0) ? "Empty String" : s;
    }

}

class StringReducer
{
    public static void Run(string[] args)
    {
        Result.superReducedString("aaabccddd ");
    }
}
