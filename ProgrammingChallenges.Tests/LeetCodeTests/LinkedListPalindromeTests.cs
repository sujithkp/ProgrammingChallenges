using GeeksForGeeksProblems.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests.LeetCodeTests
{
    public class LinkedListPalindromeTests
    {
        [Theory]
        [InlineData("1 2 2 1")]
        public void IsPalindromeTest(string arr)
        {
            var nums = arr.Split(' ').Select(x => int.Parse(x)).ToList();

            var llist = new GeeksForGeeksProblems.LeetCode.LinkedList<int>(nums);

            var linkedListPalindrome = new LinkedlistPalindrome();

            var result = linkedListPalindrome.IsPalindrome(llist.Head);

            Assert.Equal(result, true);
        }


        [Theory]
        [InlineData("1 2 2")]
        public void IsPalindromeTest2(string arr)
        {
            var nums = arr.Split(' ').Select(x => int.Parse(x)).ToList();

            var llist = new GeeksForGeeksProblems.LeetCode.LinkedList<int>(nums);

            var linkedListPalindrome = new LinkedlistPalindrome();

            var result = linkedListPalindrome.IsPalindrome(llist.Head);

            Assert.Equal(result, false);
        }
    }
}
