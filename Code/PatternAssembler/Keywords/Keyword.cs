
using System;
namespace PatternAssembler
{
   public enum KeywordTypeEnum
   {
      Operator,
      Function,
      ControlFlow,
      DataType,
      Other
   }
   public class Keyword : IKeyword
   {
      private char[] letterArray;

      public Keyword()
      {}
      public Keyword(string value, KeywordTypeEnum keywordType)
      {
         this.KeywordType = keywordType;
         this.letterArray = value.ToCharArray();
      }

      public int CharacterCount
      {
         get { return this.letterArray.Length; }
      }
      public char FirstCharacter
      {
         get { return this.letterArray[0]; }
      }

      public char CharacterAt(int position)
      {
         return this.letterArray[position];
      }

      public string Value
      {
         get{return new string(letterArray);}
      }

      public KeywordTypeEnum KeywordType { get; set; }

      #region ICloneable Members

      public object Clone()
      {
         return new Keyword(this.Value, this.KeywordType);
      }

      #endregion
   }
}
