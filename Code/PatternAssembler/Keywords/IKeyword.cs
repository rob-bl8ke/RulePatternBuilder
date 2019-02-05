using System;

namespace PatternAssembler
{
   public interface IKeyword : ICloneable
   {
      int CharacterCount { get; }
      char FirstCharacter { get; }
      string Value { get; }
      KeywordTypeEnum KeywordType { get; set; }
      char CharacterAt(int position);
      object Clone();
   }
}