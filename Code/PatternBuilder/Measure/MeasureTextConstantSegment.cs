
using PatternAssembler;

namespace PatternBuilder.Measure
{
   public class MeasureTextConstantSegment : Segment
   {
      public MeasureTextConstantSegment(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "Constant";
      }
   }
}
