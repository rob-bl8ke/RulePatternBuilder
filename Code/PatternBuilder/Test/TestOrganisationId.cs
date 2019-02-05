using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternAssembler;

namespace PatternBuilder.Test
{
   public class TestOrganisationId : Segment
   {
      public TestOrganisationId(string value, int ordinal)
         : base(value, ordinal)
      {
      }

      public override string GetCode()
      {
         return "[#ORG_ID_" + base.Ordinal.ToString() + "#]";
      }
   }
}
