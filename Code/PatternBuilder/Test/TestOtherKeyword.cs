
using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestOtherKeyword : Segment
   {
      public TestOtherKeyword(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "{other_key" + base.Ordinal.ToString() + "}";
      }
   }
}
