//using System.Text;
//using System.Collections.Generic;

//namespace PatternAssembler
//{
//   public delegate void OutputChangedHandler(string output);

//   public class Assembler
//   { 
//      public event OutputChangedHandler OutputChanged;
//      private OutputBuffer outputBuffer;

//      public Assembler(List<Keyword> keywords)
//      {
//         outputBuffer = new OutputBuffer(keywords);
//      }

//      public string PatternText
//      {
//         get { return outputBuffer.PatternText; }
//      }

//      public bool KeywordToOperator
//      {
//         get { return this.outputBuffer.KeywordToOperator; }
//         set { this.outputBuffer.KeywordToOperator = value; }
//      }

//      public void Reset()
//      {
//         outputBuffer.Reset();
//      }

//      public void ProcessToPattern(string text)
//      {
//         char[] textArray = text.ToCharArray();
//         foreach (char character in textArray)
//         {
//            outputBuffer.Write(character);
//         }
//         outputBuffer.Enter();
//      }
//   }
//}
