inputfile = open(r"C:\Users\Sujith\source\repos\ProgrammingChallenges\ProgrammingChallenges.Tests\TestData\BiggerIsGreater\input02.txt", "r")
testresultfile = open(r"C:\Users\Sujith\source\repos\ProgrammingChallenges\ProgrammingChallenges.Tests\TestData\BiggerIsGreater\output02.txt", "r")

ouputfile = open(r"C:\Users\Sujith\source\repos\ProgrammingChallenges\ProgrammingChallenges.Tests\TestData\BiggerIsGreater\inlinedata.txt", "w")

inputfile.readline(); #Skip the first line.

while True:
    testcase = inputfile.readline();
    testresult = testresultfile.readline();

    if not testcase:
        break;

    ouputfile.writelines(("[InlineData(\"" + testcase.strip() +"\"" + ",\"" + testresult.strip() + "\")]\n" ));

inputfile.close();
testresultfile.close();
