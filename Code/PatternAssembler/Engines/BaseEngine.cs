using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternAssembler
{
   public abstract class BaseEngine
   {
      protected IBuffer EngineBuffer;
      protected IPatternWriter EnginePatternWriter;
      protected readonly ICurrentKeyPress EngineCurrentKeyPress;

      public BaseEngine(IFunctionLibrary functionLibrary)
      {
         this.EngineCurrentKeyPress = new CurrentKeyPress(functionLibrary);
         this.EngineBuffer = new Buffer(functionLibrary);
         this.EnginePatternWriter = new PatternWriter(functionLibrary);
      }

      public string Create(string text)
      {
         // cycle through the text, processing as we go...
         char[] textArray = text.ToCharArray();

         for (int k = 0; k < textArray.Length; k++)
         {
            if ((k + 1) < textArray.Length)
               moveNext(textArray[k], textArray[k + 1]);
            else
               moveNext(textArray[k], '\0');
            write();
         }

         string pattern = EnginePatternWriter.GetPattern() + EngineBuffer.Text;

         reset();
         return pattern;
      }

      private void reset()
      {
         EngineCurrentKeyPress.Reset();
         EnginePatternWriter.Clear();
         EngineBuffer.Clear();
      }

      private void moveNext(char character, char nextCharacter)
      {
         EngineCurrentKeyPress.Next(character, nextCharacter);
      }

      private void write()
      {
         // the meat: write to a buffer and remove when action keys are found (identifying
         // segments by their signatures...
         if (EngineCurrentKeyPress.ProcessingRequired())
         {
            if (EngineBuffer.IsMatchedKeyword())
            {
               switch(EngineBuffer.KeywordPeek())
               {
                  case KeywordTypeEnum.ControlFlow:
                     WriteControlFlowKeyword();
                     break;
                  case KeywordTypeEnum.DataType:
                     WriteDataTypeKeyword();
                     break;
                  case KeywordTypeEnum.Function:
                     WriteFunctionKeyword();
                     break;
                  case KeywordTypeEnum.Operator:
                     WriteOperatorKeyword();
                     break;
                  case KeywordTypeEnum.Other:
                     WriteOtherKeyword();
                     break;
               }
            }

            else if (EngineBuffer.IsNumericConstant())
               WriteNumericConstant();

            else if (EngineBuffer.IsSQLServerVariable())
               WriteSqlServerVariable();

            else if (EngineBuffer.IsTextConstant())
               WriteTextConstant();

            else if (EngineBuffer.IsMatchedOrganisationId())
               WriteOrganisationId();

            else if (EngineBuffer.IsFieldOrVariable())
               WriteField();

            if (EngineCurrentKeyPress.KeyFamily == KeyFamilyEnum.OperatorKey)
               WriteOperator();
            else
               WriteAction();
         }
         else
         {
            EngineBuffer.Next(EngineCurrentKeyPress);
         }
      }

      /// <summary>
      /// Write a custom code symbol for a control flow keyword (IF, ELSE, WHEN, CASE).
      /// EnginePatternWriter.WriteKeyword(new KeywordSegment(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteControlFlowKeyword();

      /// <summary>
      /// Write a custom code symbol for a operator keyword (OR, NOT, AND).
      /// EnginePatternWriter.WriteKeyword(new KeywordSegment(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteOperatorKeyword();

      /// <summary>
      /// Write a custom code symbol for a function keyword (CONVERT, MAX).
      /// EnginePatternWriter.WriteKeyword(new KeywordSegment(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteFunctionKeyword();

      /// <summary>
      /// Write a custom code symbol for a data type keyword (VARCHAR, INT).
      /// EnginePatternWriter.WriteKeyword(new KeywordSegment(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteDataTypeKeyword();

      /// <summary>
      /// Write a custom code symbol for any other generic keyword.)
      /// EnginePatternWriter.WriteKeyword(new KeywordSegment(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteOtherKeyword();

      /// <summary>
      /// Write a custom code symbol for a numeric constant (4534, -234324, 45.23)
      /// EnginePatternWriter.WriteNumericConstant(new CustomNumericConstant(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteNumericConstant();

      /// <summary>
      /// Write a custom code symbol for a SQL Server variable (@variable_name)
      ///  EnginePatternWriter.WriteNumericConstant(new CustomSQLServerVariable(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteSqlServerVariable();

      /// <summary>
      /// Write a custom code symbol for a text constant ("Mary", "South Africa")
      /// EnginePatternWriter.WriteNumericConstant(new CustomTextConstant(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteTextConstant();

      /// <summary>
      /// Write a custom code symbol for a ORG ID ([-2343443], [345435])
      /// EnginePatternWriter.WriteNumericConstant(new CustomOrganisationId(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteOrganisationId();

      /// <summary>
      /// Write a custom code symbol for a field(COUNTRY_ID, ORDER_ID)
      /// EnginePatternWriter.WriteVariable(new CustomField(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteField();

      /// <summary>
      /// Write a custom code symbol for an operator (+, -, =)
      /// EnginePatternWriter.WriteOperator(new CustomOperator(EngineBuffer.FlushKeyword().Value, 1), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteOperator();

      /// <summary>
      /// Write a custom code symbol for an Action (usually just like this) (" ", "(", ")", ",")
      /// EnginePatternWriter.WriteActionKey(new ActionSegment(EngineCurrentKeyPress.Value, 0), EngineCurrentKeyPress);
      /// </summary>
      protected abstract void WriteAction();

   }

   
}
