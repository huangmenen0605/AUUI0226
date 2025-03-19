
using NUnit.Framework;
using UnityEngine;

public class TestScript
{
    [Test(Description = "測試兩個數字相加")]
    [TestCase(2,2,4)]
    [TestCase(1,3,4)]
    [TestCase(-1,-3,-4)]
    public void Add_Two_Number(int a, int b, int expected)
    {
        TimeConverter timeConverter = new TimeConverter();

        int result = timeConverter.Add(a,b);

        Assert.AreEqual(expected, actual: result);
    }
}
