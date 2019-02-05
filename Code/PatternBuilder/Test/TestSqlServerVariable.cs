using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestSqlServerVariable : Segment
   {
      public TestSqlServerVariable(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "[@VARIABLE_" + base.Ordinal.ToString() + "]";
      }
   }
}
