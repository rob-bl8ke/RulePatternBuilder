using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternAssembler
{
   public enum BufferedWriterModeEnum
   {
      Measure,
      Filter
   }

   internal class BufferedWriter
   {
      private BufferedWriterModeEnum mode = BufferedWriterModeEnum.Filter;
      private bool keywordToOperator;
      private StringBuilder outputBuilder = new StringBuilder();
      private StringBuilder characterBuffer = new StringBuilder();
      private List<Keyword> keywordList;

      public BufferedWriter(List<Keyword> keywordList)
      {
         this.keywordList = keywordList;
      }

      

      public void Reset()
      {
         this.outputBuilder.Remove(0, outputBuilder.Length);
         this.characterBuffer.Remove(0, characterBuffer.Length);
      }

      public BufferedWriterModeEnum WriterMode
      {
         get { return this.mode; }
         set { this.mode = value; }
      }
      public bool KeywordToOperator
      {
         get { return this.keywordToOperator; }
         set { this.keywordToOperator = value; }
      }

      public void BufferCharacter(char character)
      {
         characterBuffer.Append(character);
      }

      public void WriteActionKey(char actionKey)
      {
         WriteVariableSymbol();
         WriteCharacter(actionKey);
      }

      public void Enter()
      {
         WriteVariableSymbol();
      }

      private void WriteCharacter(char character)
      {
         outputBuilder.Append(character);
      }

      public void WriteLiteralMarker(char character)
      {
         characterBuffer.Append(character);
      }

      public void WriteOperatorSymbol()
      {
         if (!characterBuffer.ToString().Trim().Equals(string.Empty))
         {
            WriteVariableSymbol();
         }
         characterBuffer.Remove(0, characterBuffer.Length);

         outputBuilder.Append("{op}");
      }

      public void WriteVariableSymbol()
      {
         if (!characterBuffer.ToString().Trim().Equals(string.Empty))
         {
            characterBuffer.Remove(0, characterBuffer.Length);
            outputBuilder.Append("{v}");
         }
      }

      public void WriteKeyword()
      {
         outputBuilder.Append(characterBuffer.ToString());
         characterBuffer.Remove(0, characterBuffer.Length);
      }

      public override string ToString()
      {
         string replacedOutput = outputBuilder.Replace("{op}{op}", "{op}").ToString();

         if (this.keywordToOperator)
            replacedOutput = PlaceholderNumerals.ConvertKeywordsToOperators(replacedOutput, keywordList);

         replacedOutput = PlaceholderNumerals.ApplyNumerals(replacedOutput, this.mode);
         return replacedOutput.Trim() + characterBuffer.ToString();
      }
   }
}
