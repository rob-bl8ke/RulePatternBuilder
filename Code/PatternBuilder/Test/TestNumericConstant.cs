using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestNumericConstant : Segment
   {
      public TestNumericConstant(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "<<num_const_" + base.Ordinal.ToString() + ">>";
      }
   }
}
