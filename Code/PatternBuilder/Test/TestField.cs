
using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestField : Segment
   {
      public TestField(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "{field_" + base.Ordinal.ToString() + "}";
      }
   }
}
