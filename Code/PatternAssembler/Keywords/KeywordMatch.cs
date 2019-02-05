
namespace PatternAssembler
{
   internal class KeywordMatch
   {
      private int position = -1;
      private bool matchesSoFar = true;
      private bool completeMatch = false;
      private IKeyword keyword;
      private bool withinSquareBrackets = false;

      public KeywordMatch(IKeyword keyword)
      {
         this.keyword = keyword;
      }

      public bool completelyMatches()
      {
         if (position != -1 && position == (keyword.CharacterCount - 1) && this.matchesSoFar)
            return true;
         else
         {
            return false;
         }
      }

      public IKeyword Keyword
      {
         get { return this.keyword.Clone() as IKeyword; }
      }
      public bool MatchesSoFar
      {
         get { return this.matchesSoFar; }
      }

      public bool CompleteMatch
      {
         get { return this.completeMatch; }
      }

      public void Reset()
      {
         position = -1;
         matchesSoFar = true;
         this.completeMatch = false;
         withinSquareBrackets = false;
      }

      public bool NextCharacter(ICurrentKeyPress currentKey)
      {
         if (currentKey.PreviousCharacterKeyFamily == KeyFamilyEnum.ActionKey)
            Reset();

         if (currentKey.KeyFamily != KeyFamilyEnum.ActionKey)
         {
            position++;
            setEscapedStatus(currentKey);
            this.matchesSoFar = matches(currentKey);
            this.completeMatch = completelyMatches();
         }
         return matchesSoFar;
      }

      private bool matches(ICurrentKeyPress currentKey)
      {
         if (position <= keyword.CharacterCount - 1)
            return (keyword.CharacterAt(position) == currentKey.UppercaseValue) &&
               matchesSoFar && !withinSquareBrackets && position != -1;
         else
            return false;
      }

      private void setEscapedStatus(ICurrentKeyPress currentKey)
      {
         if (currentKey.Value == '[')
            withinSquareBrackets = true;

         else if (currentKey.Value == ']')
            withinSquareBrackets = false;
      }
   }
}
