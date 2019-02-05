
using PatternAssembler;
using PatternBuilder.Measure;
using PatternBuilder.Test;

namespace PatternBuilder
{
   public class TestEngine : BaseEngine
   {
      public TestEngine(IFunctionLibrary functionLibrary)
         : base(functionLibrary)
      {
         
      }

      private int cf_keyword_incrementor = 0;
      private int dt_keyword_incrementor = 0;
      private int f_keyword_incrementor = 0;
      private int op_keyword_incrementor = 0;
      private int text_const_incrementor = 0;
      private int num_const_incrementor = 0;
      private int org_id_incrementor = 0;
      private int oth_keyword_incrementor = 0;
      private int sql_var_incrementor = 0;
      private int fld_incrementor = 0;
      private int oper_incrementor = 0;

      protected override void WriteControlFlowKeyword()
      {
         EnginePatternWriter.WriteKeyword(new TestControlFlowKeyword(EngineBuffer.FlushKeyword().Value, ++cf_keyword_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteDataTypeKeyword()
      {
         EnginePatternWriter.WriteKeyword(new TestDataTypeKeyword(EngineBuffer.FlushKeyword().Value, ++dt_keyword_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteFunctionKeyword()
      {
         EnginePatternWriter.WriteKeyword(new TestFunctionKeyword(EngineBuffer.FlushKeyword().Value, ++f_keyword_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteOperatorKeyword()
      {
         EnginePatternWriter.WriteKeyword(new TestOperatorKeyword(EngineBuffer.FlushKeyword().Value, ++op_keyword_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteOtherKeyword()
      {
         EnginePatternWriter.WriteKeyword(new TestOtherKeyword(EngineBuffer.FlushKeyword().Value, ++oth_keyword_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteNumericConstant()
      {
         EnginePatternWriter.WriteNumericConstant(new TestNumericConstant(EngineBuffer.Flush(), ++num_const_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteOrganisationId()
      {
         EnginePatternWriter.WriteOrganisationId(new TestOrganisationId(EngineBuffer.Flush(), ++org_id_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteSqlServerVariable()
      {
         EnginePatternWriter.WriteSqlServerVariable(new TestSqlServerVariable(EngineBuffer.Flush(), ++sql_var_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteTextConstant()
      {
         EnginePatternWriter.WriteTextConstant(new TestTextConstant(EngineBuffer.Flush(), ++text_const_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteField()
      {
         EnginePatternWriter.WriteField(new TestField(EngineBuffer.Flush(), ++fld_incrementor), EngineCurrentKeyPress);
      }

      protected override void WriteAction()
      {
         EnginePatternWriter.WriteActionKey(new ActionSegment(EngineCurrentKeyPress.Value, 0), EngineCurrentKeyPress);
      }

      protected override void WriteOperator()
      {
         EnginePatternWriter.WriteOperator(new TestOperator(EngineCurrentKeyPress.Value.ToString(), ++oper_incrementor), EngineCurrentKeyPress);
      }
   }
}
