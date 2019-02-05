
using PatternAssembler;

namespace PatternBuilder.Filter
{
   public class FilterVariableSegment : Segment
   {
      public FilterVariableSegment(string value, int ordinal) :base(value, ordinal)
      {
         
      }

      public override string GetCode()
      {
         return "{v" + base.Ordinal + "}";
      }
   }
}
