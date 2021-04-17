class Solution {
    subarraySum(arr, n, sumReq) {
        var startIndex = 0;
        var endindex = 0;
        var sum = 0;

        var found = false;

        while (startIndex < n) {
            sum = sum + arr[startIndex];

            if (sum > sumReq) {
                sum -= arr[endindex];

                if (endindex < startIndex) {
                    sum -= arr[startIndex];
                    endindex++;

                    continue;
                }
            }

            if (endindex == startIndex)
                endindex++;

            if (sum == sumReq) {
                found = true;
                return [endindex + 1, startIndex + 1];
            }

            startIndex++;
        }

        if (!found)
            return [-1];
    }
}

function FormatArray(arr) {
    return arr.join(",");
}

var result = new Solution().subarraySum([193, 55, 70, 82, 66, 68, 114, 194, 35, 73, 173, 31, 102, 43, 178, 78, 171, 103, 165, 182, 191, 24, 38, 24, 180, 196, 170, 128, 43, 111, 183, 59, 127, 88, 71, 129, 52, 59, 14, 61, 184, 87, 143, 11, 73, 129, 35, 42, 119, 104, 68
], 51, 150);

console.log(result);