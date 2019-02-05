using PatternAssembler;

namespace PatternBuilder
{
   public class TestFunctionKeyword : Segment
   {
      public TestFunctionKeyword(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "{f_key" + base.Ordinal.ToString() + "}";
      }
   }
}
