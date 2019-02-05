using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestTextConstant : Segment
   {
      public TestTextConstant(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "<<text_const_" + base.Ordinal.ToString() + ">>";
      }
   }
}
