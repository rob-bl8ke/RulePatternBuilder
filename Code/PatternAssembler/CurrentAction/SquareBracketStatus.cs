//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace PatternAssembler
//{
//   internal class SquareBracketStatus
//   {
//      public bool WithinBrackets { get; set; }

//      public void Reset()
//      {
//         WithinBrackets = false;
//      }

//      public void Next(ICurrentKeyPress currentKey)
//      {
//         if (currentKey.Value == '[' && (!WithinBrackets))
//         {
//            WithinBrackets = true;
//         }
//         else if (currentKey.Value == ']' && WithinBrackets)
//         {
//            WithinBrackets = false;
//         }
//      }
//   }
//}
