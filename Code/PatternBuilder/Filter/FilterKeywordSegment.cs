
using PatternAssembler;

namespace PatternBuilder.Filter
{
   public class FilterKeywordSegment : Segment
   {
      public FilterKeywordSegment(string value, int ordinal) :base(value, ordinal)
      {
         
      }

      public override string GetCode()
      {
         return base.Value;
      }
   }
}
