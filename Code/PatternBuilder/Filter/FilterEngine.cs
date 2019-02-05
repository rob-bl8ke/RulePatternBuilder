using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;
using PatternBuilder.Filter;

namespace PatternBuilder
{
   public class FilterEngine : BaseEngine
   {

      public FilterEngine(IFunctionLibrary functionLibrary)
         : base(functionLibrary)
      {
         
      }

      private int var_incrementor = 0;
      private int op_incrementor = 0;

      protected override void WriteAction()
      {
         EnginePatternWriter.WriteActionKey(new ActionSegment(EngineCurrentKeyPress.Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteControlFlowKeyword()
      {
         EnginePatternWriter.WriteKeyword(new FilterKeywordSegment(EngineBuffer.FlushKeyword().Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteDataTypeKeyword()
      {
         EnginePatternWriter.WriteKeyword(new FilterKeywordSegment(EngineBuffer.FlushKeyword().Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteFunctionKeyword()
      {
         EnginePatternWriter.WriteKeyword(new FilterKeywordSegment(EngineBuffer.FlushKeyword().Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteOperatorKeyword()
      {
         EnginePatternWriter.WriteKeyword(new FilterKeywordSegment(EngineBuffer.FlushKeyword().Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteOtherKeyword()
      {
         EnginePatternWriter.WriteKeyword(new FilterKeywordSegment(EngineBuffer.FlushKeyword().Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteNumericConstant()
      {
         EnginePatternWriter.WriteNumericConstant(new FilterVariableSegment(EngineBuffer.Flush(), ++var_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteOrganisationId()
      {
         EnginePatternWriter.WriteNumericConstant(new FilterVariableSegment(EngineBuffer.Flush(), ++var_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteSqlServerVariable()
      {
         EnginePatternWriter.WriteNumericConstant(new FilterVariableSegment(EngineBuffer.Flush(), ++var_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteTextConstant()
      {
         EnginePatternWriter.WriteNumericConstant(new FilterVariableSegment(EngineBuffer.Flush(), ++var_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteField()
      {
         EnginePatternWriter.WriteNumericConstant(new FilterVariableSegment(EngineBuffer.Flush(), ++var_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteOperator()
      {
         EnginePatternWriter.WriteOperator(new FilterOperatorSegment(EngineCurrentKeyPress.Value.ToString(), ++op_incrementor), EngineCurrentKeyPress);
      }
   }
}
