using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;

namespace PatternBuilder.Measure
{
   public class MeasureFunctionKeywordSegment : Segment
   {
      public MeasureFunctionKeywordSegment(string value, int ordinal): base(value, ordinal)
      {
         
      }

      public override string GetCode()
      {
         return "F" + base.Ordinal;
      }
   }
}
