using PatternAssembler;
using PatternBuilder.Measure;

namespace PatternBuilder
{
   public class MeasureEngine : BaseEngine
   {
      public MeasureEngine(IFunctionLibrary functionLibrary)
         : base(functionLibrary)
      {
         
      }

      private int func_keyword_incrementor = 0;
      private int operator_incrementor = 0;
      private int field_incrementor = 0;
      private int org_id_incrementer = 0;
     

      protected override void WriteControlFlowKeyword()
      {
         EnginePatternWriter.WriteKeyword(new MeasureKeywordSegment(EngineBuffer.FlushKeyword().Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteDataTypeKeyword()
      {
         EnginePatternWriter.WriteKeyword(new MeasureKeywordSegment(EngineBuffer.FlushKeyword().Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteFunctionKeyword()
      {
         EnginePatternWriter.WriteKeyword(new MeasureFunctionKeywordSegment(EngineBuffer.FlushKeyword().Value, ++func_keyword_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteOperatorKeyword()
      {
         EnginePatternWriter.WriteKeyword(new MeasureKeywordSegment(EngineBuffer.FlushKeyword().Value, ++operator_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteOtherKeyword()
      {
         EnginePatternWriter.WriteKeyword(new MeasureKeywordSegment(EngineBuffer.FlushKeyword().Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteNumericConstant()
      {
         EnginePatternWriter.WriteNumericConstant(new MeasureNumericConstantSegment(EngineBuffer.Flush(), 0), EngineCurrentKeyPress);
      }

      protected override void WriteOrganisationId()
      {
         EnginePatternWriter.WriteOrganisationId(new MeasureOrganisationIdSegment(EngineBuffer.Flush(), ++org_id_incrementer), EngineCurrentKeyPress);
      }

      protected override void WriteSqlServerVariable()
      {
         EnginePatternWriter.WriteSqlServerVariable(new MeasureSqlServerVariableSegment(EngineBuffer.Flush(), 0), EngineCurrentKeyPress);
      }

      protected override void WriteTextConstant()
      {
         EnginePatternWriter.WriteTextConstant(new MeasureTextConstantSegment(EngineBuffer.Flush(), 0), EngineCurrentKeyPress);
      }

      protected override void WriteField()
      {
         EnginePatternWriter.WriteField(new MeasureFieldSegment(EngineBuffer.Flush(), ++field_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteAction()
      {
         EnginePatternWriter.WriteActionKey(new ActionSegment(EngineCurrentKeyPress.Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteOperator()
      {
         EnginePatternWriter.WriteOperator(new MeasureOperatorSegment(EngineCurrentKeyPress.Value.ToString(), ++operator_incrementor), EngineCurrentKeyPress);
      }
   }
}
