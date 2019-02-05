
using PatternAssembler;

namespace PatternBuilder
{
   public class MeasureNumericConstantSegment : Segment
   {
      public MeasureNumericConstantSegment(string value, int ordinal) :base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "(ConstantValue)";
      }
   }
}
