
using System.Collections.Generic;

public class CsharpPractice 
{
   public int Add(int a , int b)
   {
       return a + b;
   }

   private Dictionary<string , string> localizationTexts = new Dictionary<string , string>()
   {
       { "Apple" , "蘋果" } , { "Banana" , "香蕉" }
   };

   public string GetLocalizationTexts(string key)
   {
       // if (language == "中文")
       // {
       //     if (key == "Apple")
       //     {
       //         return "蘋果";
       //     }
       // }

       var value = localizationTexts[key];
       return value;

       // return "";
   }

   // 英轉中 ...
   private Dictionary<string , string> localizationTexts_EnglishToChinese =
           new Dictionary<string , string>() { { "Apple" , "蘋果" } , { "Banana" , "香蕉" } , };

   /// 中轉英 ...
   private Dictionary<string , string> localizationTexts_ChineseToEnglish =
           new Dictionary<string , string>() { { "蘋果" , "Apple" } , { "香蕉" , "Banana" } , };

   public enum Language
   {
       英文轉中文 = 0 ,
       中文轉英文 = 10 ,
   }

   public string GetLocalizationText(Language language,string key)
   {
       /* if (language == "中文") ... */
       if (language == Language.英文轉中文)
       {
           return localizationTexts_EnglishToChinese[key];
       }

       if (language == Language.中文轉英文)
       {
           return localizationTexts_ChineseToEnglish[key];
       }

       return "";
   }
}
