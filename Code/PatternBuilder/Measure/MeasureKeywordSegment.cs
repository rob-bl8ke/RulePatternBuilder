
using PatternAssembler;

namespace PatternBuilder.Measure
{
   public class MeasureKeywordSegment : Segment
   {
      public MeasureKeywordSegment(string value, int ordinal)
         : base(value, ordinal)
      {
         
      }

      public override string GetCode()
      {
         return base.Value;
      }
   }
}
