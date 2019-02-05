using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestControlFlowKeyword : Segment
   {
      public TestControlFlowKeyword(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "{cf_key" + base.Ordinal.ToString() + "}";
      }
   }
}
