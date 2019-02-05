using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestOperatorKeyword : Segment
   {
      public TestOperatorKeyword(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "{op_key" + base.Ordinal.ToString() + "}";
      }
   }
}
