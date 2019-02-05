using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestOperator : Segment
   {
      public TestOperator(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "{op_" + base.Ordinal.ToString() + "}";
      }
   }
}
