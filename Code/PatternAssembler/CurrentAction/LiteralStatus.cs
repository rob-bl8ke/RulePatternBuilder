namespace PatternAssembler
{
   internal class LiteralStatus
   {
      private char openBracketChar = '\0';
      private bool within = false;

      public bool WithinLiteralString
      {
         get { return this.within; }
      }

      public void Reset()
      {
         openBracketChar = '\0';
         within = false;
      }

      public void Next(ICurrentKeyPress currentKey)
      {
         if (currentKey.Value == '"' || currentKey.Value == '\'')
         {
            if (!within)
               openBracketChar = currentKey.Value;

            if (openBracketChar == currentKey.Value)
               within = !within;

            if (!within)
               openBracketChar = '\0';
         }
      }

   }
}
