using PatternAssembler;

namespace PatternBuilder
{
   public class ActionSegment : Segment
   {
      public ActionSegment(char value, int ordinal)
         : base(value.ToString(), ordinal)
      {
      }

      public override string GetCode()
      {
         return base.Value;
      }
   }
}
