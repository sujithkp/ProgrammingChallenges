using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class EncryptionTests
    {
        [Theory]
        [InlineData("if man was meant to stay on the ground god would have given us roots")]
        [InlineData("chillout")]
        public void Test1(string str)
        {
            var result = Encryption.encryption(str);
        }
    }
}
