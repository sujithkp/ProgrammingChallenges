using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class BiggerIsGreaterTest
    {
        [Theory]
        [InlineData()]
        public void Test1()
        {
            var result = BiggerIsGreaterSoution.BiggerIsGreater("hefg");

            Assert.Equal("hegf", result);
        }


        #region Test 2

        [Theory]
        [InlineData("imllmmcslslkyoegymoa", "imllmmcslslkyoegyoam")]
        [InlineData("fvincndjrurfh", "fvincndjrurhf")]
        [InlineData("rtglgzzqxnuflitnlyit", "rtglgzzqxnuflitnlyti")]
        [InlineData("mhtvaqofxtyrz", "mhtvaqofxtyzr")]
        [InlineData("zalqxykemvzzgaka", "zalqxykemvzzgkaa")]
        [InlineData("wjjulziszbqqdcpdnhdo", "wjjulziszbqqdcpdnhod")]
        [InlineData("japjbvjlxzkgietkm", "japjbvjlxzkgietmk")]
        [InlineData("jqczvgqywydkunmjw", "jqczvgqywydkunmwj")]
        [InlineData("ehdegnmorgafrjxvksc", "ehdegnmorgafrjxvsck")]
        [InlineData("tydwixlwghlmqo", "tydwixlwghlomq")]
        [InlineData("wddnwjneaxbwhwamr", "wddnwjneaxbwhwarm")]
        [InlineData("pnimbesirfbivxl", "pnimbesirfbixlv")]
        [InlineData("mijamkzpiiniveik", "mijamkzpiiniveki")]
        [InlineData("qxtwpdpwexuej", "qxtwpdpwexuje")]
        [InlineData("qtcshorwyck", "qtcshorwykc")]
        [InlineData("xoojiggdcyjrupr", "xoojiggdcyjrurp")]
        [InlineData("vcjmvngcdyabcmjz", "vcjmvngcdyabcmzj")]
        [InlineData("xildrrhpca", "xildrrpach")]
        [InlineData("rrcntnbqchsfhvijh", "rrcntnbqchsfhvjhi")]
        [InlineData("kmotatmrabtcomu", "kmotatmrabtcoum")]
        [InlineData("bnfcejmyotvw", "bnfcejmyotwv")]
        [InlineData("dnppdkpywiaxddoqx", "dnppdkpywiaxddoxq")]
        [InlineData("tmowsxkrodmkkra", "tmowsxkrodmkrak")]
        [InlineData("jfkaehlegohwggf", "jfkaehlegowfggh")]
        [InlineData("ttylsiegnttymtyx", "ttylsiegnttymxty")]
        [InlineData("kyetllczuyibdkwyihrq", "kyetllczuyibdkwyiqhr")]
        [InlineData("xdhqbvlbtmmtshefjf", "xdhqbvlbtmmtshejff")]
        [InlineData("kpdpzzohihzwgdfzgb", "kpdpzzohihzwgdgbfz")]
        [InlineData("kuywptftapaa", "kuywptftpaaa")]
        [InlineData("qfqpegznnyludrv", "qfqpegznnyludvr")]
        [InlineData("ufwogufbzaboaepslikq", "ufwogufbzaboaepsliqk")]
        [InlineData("jfejqapjvbdcxtkry", "jfejqapjvbdcxtkyr")]
        [InlineData("sypjbvatgidyxodd", "sypjbvatgiodddxy")]
        [InlineData("wdpfyqjcpcn", "wdpfyqjcpnc")]
        [InlineData("baabpjckkytudr", "baabpjckkyturd")]
        [InlineData("uvwurzjyzbhcqmrypraq", "uvwurzjyzbhcqmryprqa")]
        [InlineData("kvtwtmqygksbim", "kvtwtmqygksbmi")]
        [InlineData("ivsjycnooeodwpt", "ivsjycnooeodwtp")]
        [InlineData("zqyxjnnitzawipqsm", "zqyxjnnitzawipsmq")]
        [InlineData("blmrzavodtfzyepz", "blmrzavodtfzyezp")]
        [InlineData("bmqlhqndacv", "bmqlhqndavc")]
        [InlineData("phvauobwkrcfwdecsd", "phvauobwkrcfwdedcs")]
        [InlineData("vpygyqubqywkndhpzw", "vpygyqubqywkndhwpz")]
        [InlineData("yikanhdrjxw", "yikanhdrwjx")]
        [InlineData("vnpblfxmvwkflqobrk", "vnpblfxmvwkflqokbr")]
        [InlineData("pserilwzxwyorldsxksl", "pserilwzxwyorldsxlks")]
        [InlineData("qymbqaehnyzhfqpqprpl", "qymbqaehnyzhfqpqrlpp")]
        [InlineData("fcakwzuqlzglnibqmkd", "fcakwzuqlzglnidbkmq")]
        [InlineData("jkscckttaeifiksgkmxx", "jkscckttaeifiksgkxmx")]
        [InlineData("dkbllravwnhhfjjrce", "dkbllravwnhhfjjrec")]
        [InlineData("imzsyrykfvjt", "imzsyrykfvtj")]
        [InlineData("tvogoocldlukwfcajvix", "tvogoocldlukwfcajvxi")]
        [InlineData("cvnagtypozljpragvlj", "cvnagtypozljprajglv")]
        [InlineData("hwcmacxvmus", "hwcmacxvsmu")]
        [InlineData("rhrzcpprqccf", "rhrzcpprqcfc")]
        [InlineData("clppxvwtaktchqrdif", "clppxvwtaktchqrfdi")]
        [InlineData("qwusnlldnolhq", "qwusnlldnolqh")]
        [InlineData("yitveovrja", "yitverajov")]
        [InlineData("arciyxaxtvmfgquwb", "arciyxaxtvmfgqwbu")]
        [InlineData("pzbxvxdjuuvuv", "pzbxvxdjuuvvu")]
        [InlineData("nxfowilpdxwlpt", "nxfowilpdxwltp")]
        [InlineData("swzsaynxbytytqtq", "swzsaynxbytyttqq")]
        [InlineData("qyrogefleeyt", "qyrogefletey")]
        [InlineData("iotjgthvslvmjpcchhuf", "iotjgthvslvmjpcchufh")]
        [InlineData("knfpyjtzfq", "knfpyjtzqf")]
        [InlineData("tmtbfayantmwk", "tmtbfayantwkm")]
        [InlineData("asxwzygngwn", "asxwzygnngw")]
        [InlineData("rmwiwrurubt", "rmwiwrurutb")]
        [InlineData("bhmpfwhgqfcqfldlhs", "bhmpfwhgqfcqfldlsh")]
        [InlineData("yhbidtewpgp", "yhbidtewppg")]
        [InlineData("jwwbeuiklpodvzii", "jwwbeuiklpodziiv")]
        [InlineData("anjhprmkwibe", "anjhprmkwieb")]
        [InlineData("lpwhqaebmr", "lpwhqaebrm")]
        [InlineData("dunecynelymcpyonjq", "dunecynelymcpyonqj")]
        [InlineData("hblfldireuivzekegit", "hblfldireuivzekegti")]
        [InlineData("uryygzpwifrricwvge", "uryygzpwifrriecgvw")]
        [InlineData("kzuhaysegaxtwqtvx", "kzuhaysegaxtwqtxv")]
        [InlineData("kvarmrbpoxxujhvgpw", "kvarmrbpoxxujhvgwp")]
        [InlineData("hanhaggqzdpunkugzmhq", "hanhaggqzdpunkugzmqh")]
        [InlineData("gnwqwsylqeuqr", "gnwqwsylqeurq")]
        [InlineData("qzkjbnyvclrkmdtc", "qzkjbnyvclrkmtcd")]
        [InlineData("argsnaqbquv", "argsnaqbqvu")]
        [InlineData("obbnlkoaklcx", "obbnlkoaklxc")]
        [InlineData("ojiilqieycsasvqosycu", "ojiilqieycsasvqosyuc")]
        [InlineData("qhlgiwsmtxbffjsxt", "qhlgiwsmtxbffjtsx")]
        [InlineData("vvrvnmndeogyp", "vvrvnmndeopgy")]
        [InlineData("ibeqzyeuvfzb", "ibeqzyeuvzbf")]
        [InlineData("sajpyegttujxyx", "sajpyegttujyxx")]
        [InlineData("zmdjphzogfldlkgbchnt", "zmdjphzogfldlkgbchtn")]
        [InlineData("tbanvjmwirxx", "tbanvjmwixrx")]
        [InlineData("gmdhdlmopzyvddeqyjja", "gmdhdlmopzyvddeyajjq")]
        [InlineData("yxvmvedubzcpd", "yxvmvedubzdcp")]
        [InlineData("soygdzhbckfuk", "soygdzhbckkfu")]
        [InlineData("gkbekyrhcwc", "gkbekyrhwcc")]
        [InlineData("wevzqpnqwtpfu", "wevzqpnqwtpuf")]
        [InlineData("rbobquotbysufwqjeo", "rbobquotbysufwqjoe")]
        [InlineData("bpgqfwoyntuhkvwo", "bpgqfwoyntuhkwov")]
        [InlineData("schtabphairewhfmp", "schtabphairewhfpm")]
        [InlineData("rlmrahlisggguykeu", "rlmrahlisggguykue")]
        [InlineData("fjtfrmlqvsekq", "fjtfrmlqvseqk")]
        public void Test2(string input, string expectation)
        {
            var result = BiggerIsGreaterSoution.BiggerIsGreater(input);

            Assert.Equal(expectation, result);
        }

        #endregion


        [Theory]
        [InlineData("dcba", "no answer")]
        public void Test3(string input, string expected)
        {
            var result = BiggerIsGreaterSoution.BiggerIsGreater(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("arciyxaxtvmfgquwb", "arciyxaxtvmfgqwbu")]
        public void Test4(string input, string expected)
        {
            var result = BiggerIsGreaterSoution.BiggerIsGreater(input);

            Assert.Equal(expected, result);
        }
    }
}
