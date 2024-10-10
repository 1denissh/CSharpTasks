using ConsoleApp1;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ConsoleApp1Tests;

[TestFixture]
public class SolutionTests
{
    [TestCase("]", false)]
    [TestCase("()", true)]
    [TestCase("(]", false)]
    [TestCase("()[]{}", true)]
    [TestCase("([]){}", true)]
    [TestCase("([]{)}", false)]
    public void IsValidTest_01(string s, bool result)
    {
        Assert.AreEqual(new Solution().IsValid(s), result);
    }
}