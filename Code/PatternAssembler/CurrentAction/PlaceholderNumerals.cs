//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace PatternAssembler
//{
//   internal static class PlaceholderNumerals
//   {
//      public static string ApplyNumerals(string patternString, BufferedWriterModeEnum mode)
//      {
//         int varCounter = 0;
//         int opCounter = 0;
//         //int fldCounter = 0;

//         while (patternString.Contains("{v}"))
//         {
//            varCounter++;
//            if (mode == BufferedWriterModeEnum.Filter)
//               patternString = ReplaceFirst(patternString, "{v}", "{v" + varCounter.ToString() + "}");
//            else
//               patternString = ReplaceFirst(patternString, "{v}", "{col" + varCounter.ToString() + "}");
//         }

//         while (patternString.Contains("{op}"))
//         {
//            opCounter++;
//            if (mode == BufferedWriterModeEnum.Filter)
//               patternString = ReplaceFirst(patternString, "{op}", "{op" + opCounter.ToString() + "}");
//            else
//               patternString = ReplaceFirst(patternString, "{op}", "{O" + opCounter.ToString() + "}");
//         }
//         return patternString;
//      }

//      public static string ConvertKeywordsToOperators(string patternString, List<IKeyword> keywords)
//      {
//         foreach (IKeyword keyword in keywords)
//         {
//            if (keyword.KeywordType == KeywordTypeEnum.Operator)
//            {
//               while (Contains(patternString, keyword.Value, StringComparison.OrdinalIgnoreCase))
//               {
//                  patternString = ReplaceString(patternString, keyword.Value, "{op}", StringComparison.OrdinalIgnoreCase);
//               }
//            }
//         }
//         return patternString;
//      }

//      private static string ReplaceFirst(string text, string search, string replace)
//      {
//         int pos = text.IndexOf(search);
//         if (pos < 0)
//         {
//            return text;
//         }
//         return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
//      }

//      private static bool Contains(string pattern, string keyword, StringComparison comparison)
//      {
//         int index = pattern.IndexOf(keyword, comparison);

//         if (index == -1)
//            return false;
//         else
//            return true;
//      }

//      private static string ReplaceString(string str, string oldValue, string newValue, StringComparison comparison)
//      {
//         StringBuilder sb = new StringBuilder();

//         int previousIndex = 0;
//         int index = str.IndexOf(oldValue, comparison);
//         while (index != -1)
//         {
//            sb.Append(str.Substring(previousIndex, index - previousIndex));
//            sb.Append(newValue);
//            index += oldValue.Length;

//            previousIndex = index;
//            index = str.IndexOf(oldValue, index, comparison);
//         }
//         sb.Append(str.Substring(previousIndex));

//         return sb.ToString();
//      } 
//   }
//}
