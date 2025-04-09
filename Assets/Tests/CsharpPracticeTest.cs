
using NUnit.Framework;
using UnityEngine;

public class CsharpPracticeTest
{
    [Test(Description = "測試兩個數字相加")]
    [TestCase(2,2,4)]
    [TestCase(1,3,4)]
    [TestCase(-1,-3,-4)]
    public void Add_Two_Number(int a, int b, int expected)
    {
        CsharpPractice csharpPractice = new CsharpPractice();

        int result = csharpPractice.Add(a,b);

        Assert.AreEqual(expected, actual: result);
    }

    [Test(Description = "取得語言本地化文字")]
    [TestCase(CsharpPractice.Language.英文轉中文,  "Apple" ,  "蘋果")]
    [TestCase(CsharpPractice.Language.英文轉中文 , "Banana" , "香蕉")]
    [TestCase(CsharpPractice.Language.中文轉英文 , "蘋果" ,  "Apple")]
    [TestCase(CsharpPractice.Language.中文轉英文 , "香蕉" , "Banana")]
    public void GetLocalizationText(CsharpPractice.Language language ,string key , string expectedText)
    {
        var csharpPractice = new CsharpPractice();

        var text = csharpPractice.GetLocalizationText(language,key);

        Assert.AreEqual(expected: expectedText, actual: text);
    }
    
}
