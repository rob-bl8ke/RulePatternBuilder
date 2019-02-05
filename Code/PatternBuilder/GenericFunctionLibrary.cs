using System;
using System.Collections.Generic;
using System.Linq;
using PatternAssembler;
using System.Text.RegularExpressions;

namespace PatternBuilder
{
   public class GenericFunctionLibrary : IFunctionLibrary
   {
      #region IFunctionLibrary Members

      public bool IsLiteralKey(char character)
      {
         char[] mirrorArray = new char[2] { '\'', '"' };

         foreach (char ch in mirrorArray)
         {
            if (ch == character)
               return true;
         }
         return false;
      }

      public bool IsNegativeNumber(char previousCharacter, char currentCharacter, char nextCharacter)
      {
         if (currentCharacter == '-' && char.IsDigit(nextCharacter) && !char.IsDigit(previousCharacter))
            return true;
         return false;
      }

      public bool IsActionKey(char character)
      {
         if (IsNonOperatorActionKey(character) || IsOperatorActionKey(character))
            return true;
         return false;
      }

      public bool IsNonOperatorActionKey(char character)
      {
         char[] mirrorArray = new char[5] { ',', '(', ')', ' ', ';' };

         foreach (char ch in mirrorArray)
         {
            if (ch == character)
               return true;
         }
         return false;
      }

      public bool IsOperatorActionKey(char character)
      {
         var validOperators = new char[14] { '~', '+', '-', '*', '/', '%', '=', '&', '|', '^', '=', '>', '<', '!' };
         return validOperators.Contains(character);
      }

      public bool IsValidOperator(string textString)
      {
         var operators = new string[27]
                                    {
                                       "~",
                                       "+",
                                       "-",
                                       "*",
                                       "/",
                                       "%",
                                       "=",
                                       "=",
                                       ">",
                                       "<",
                                       ">=",
                                       "<=",
                                       "<>",
                                       "!=",
                                       "!<",
                                       "!>",
                                       "+=",
                                       "-=",
                                       "*=",
                                       "/=",
                                       "%=",
                                       "&=",
                                       "^=",
                                       "|=",
                                       "&",
                                       "|",
                                       "^"
                                    };

         return operators.Contains(textString);
      }

      public bool IsFieldOrVariableKey(char character)
      {
         if (Char.IsLetterOrDigit(character) || character == '_')
            return true;
         else
            return false;
      }

      public List<IKeyword> AllKeywords()
      {
         List<IKeyword> keywords = new List<IKeyword>();

         keywords.Add(new Keyword("AND", KeywordTypeEnum.Operator));
         keywords.Add(new Keyword("OR", KeywordTypeEnum.Operator));
         keywords.Add(new Keyword("NOT", KeywordTypeEnum.Operator));
         keywords.Add(new Keyword("IN", KeywordTypeEnum.Operator));
         keywords.Add(new Keyword("EXISTS", KeywordTypeEnum.Operator));

         keywords.Add(new Keyword("SELECT", KeywordTypeEnum.Other));
         keywords.Add(new Keyword("DISTINCT", KeywordTypeEnum.Other));
         keywords.Add(new Keyword("FROM", KeywordTypeEnum.Other));

         keywords.Add(new Keyword("DATE", KeywordTypeEnum.DataType));
         keywords.Add(new Keyword("DATETIME", KeywordTypeEnum.DataType));
         keywords.Add(new Keyword("INT", KeywordTypeEnum.DataType));
         keywords.Add(new Keyword("BIGINT", KeywordTypeEnum.DataType));
         keywords.Add(new Keyword("BIT", KeywordTypeEnum.DataType));
         keywords.Add(new Keyword("VARCHAR", KeywordTypeEnum.DataType));
         keywords.Add(new Keyword("BETWEEN", KeywordTypeEnum.Operator));

         keywords.Add(new Keyword("BEGIN", KeywordTypeEnum.ControlFlow));
         keywords.Add(new Keyword("END", KeywordTypeEnum.ControlFlow));
         keywords.Add(new Keyword("IF", KeywordTypeEnum.ControlFlow));
         keywords.Add(new Keyword("ELSE", KeywordTypeEnum.ControlFlow));
         keywords.Add(new Keyword("CASE", KeywordTypeEnum.ControlFlow));
         keywords.Add(new Keyword("WHEN", KeywordTypeEnum.ControlFlow));

         keywords.Add(new Keyword("SUM", KeywordTypeEnum.Function));
         keywords.Add(new Keyword("POWER", KeywordTypeEnum.Function));
         keywords.Add(new Keyword("MAX", KeywordTypeEnum.Function));
         keywords.Add(new Keyword("MIN", KeywordTypeEnum.Function));
         keywords.Add(new Keyword("CONVERT", KeywordTypeEnum.Function));
         keywords.Add(new Keyword("ABS", KeywordTypeEnum.Function));
         keywords.Add(new Keyword("ISNULL", KeywordTypeEnum.Function));
         keywords.Add(new Keyword("SQRT", KeywordTypeEnum.Function));

         return keywords;
      }

      public bool IsSqlServerVariable(string text)
      {
         return text.StartsWith("@");
      }

      public bool IsMatchedOrganisationId(string text)
      {
         return Regex.IsMatch(text, @"\[-*\d{1,}\]");
      }

      public bool IsTextConstant(string text)
      {
         //return Regex.IsMatch(bufferBuilder.ToString(), "\"{1}[\.\d\w\s-+=,:;!?()\[\]]*\"{1}")
         
         if ((text.StartsWith("\"") && text.EndsWith("\"")) || (text.StartsWith("'") && text.EndsWith("'")))
            return true;

         return false;
      }

      public bool IsFieldOrVariable(string text)
      {
         Regex regex = new Regex("^[a-zA-Z_][a-zA-Z0-9_]*$");
         Match match = regex.Match(text);

         return match.Success;
      }

      public bool IsNumericConstant(string text)
      {
         double num;
         return Double.TryParse(text, out num);
      }
      #endregion

 
   }
}
