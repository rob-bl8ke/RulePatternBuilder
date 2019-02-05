

using PatternAssembler;
namespace PatternBuilder.Filter
{
   public class FilterOperatorSegment : Segment
   {
      public FilterOperatorSegment(string value, int ordinal): base(value, ordinal)
      {
         
      }

      public override string GetCode()
      {
         return "{op" + base.Ordinal + "}";
      }
   }
}
