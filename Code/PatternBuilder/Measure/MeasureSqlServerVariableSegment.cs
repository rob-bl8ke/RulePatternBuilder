
using PatternAssembler;

namespace PatternBuilder
{
   public class MeasureSqlServerVariableSegment : Segment
   {
      public MeasureSqlServerVariableSegment(string value, int ordinal):base(value, ordinal)
      {
         
      }

      public override string GetCode()
      {
         return "@Variable";
      }
   }
}
