using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestDataTypeKeyword : Segment
   {
      public TestDataTypeKeyword(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "{dt_key" + base.Ordinal.ToString() + "}";
      }
   }
}
