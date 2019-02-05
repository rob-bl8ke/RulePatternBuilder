using System.Collections.Generic;

namespace PatternAssembler
{
   public enum BufferedWriterModeEnum
   {
      Measure,
      Filter,
      Test
   }

   public class PatternEngine
   {
      private BaseEngine engine;

      public void LoadEngine(BaseEngine customEngine)
      {
         this.engine = customEngine;
      }

      public string CreatePattern(string text)
      {
         if (this.engine != null)
            return engine.Create(text);
         else
            return "";
      }
   }
}
