using System.Collections.Generic;
using System.Linq;

namespace PatternAssembler
{
   internal class KeywordMatchService
   {
      List<KeywordMatch> keywordMatchList = new List<KeywordMatch>();
      IFunctionLibrary functionLibrary;

      public KeywordMatchService(IFunctionLibrary functionLibrary)
      {
         this.functionLibrary = functionLibrary;
         //List<IKeyword> keywordsList = ComponentActionLibrary.AllKeywords();

         List<IKeyword> keywordsList = functionLibrary.AllKeywords();
         foreach (IKeyword keyword in keywordsList)
         {
            keywordMatchList.Add(new KeywordMatch(keyword));
         }
      }

      public bool Next(ICurrentKeyPress currentKey)
      {
         foreach (KeywordMatch keywordMatch in keywordMatchList)
            keywordMatch.NextCharacter(currentKey);

         bool match = keywordMatchList.Any(keywordMatch => keywordMatch.MatchesSoFar);
         return match;
      }

      public void Reset()
      {
         foreach (KeywordMatch keywordMatch in keywordMatchList)
            keywordMatch.Reset();
      }

      public bool CompleteMatch
      {
         get
         {
            bool match = keywordMatchList.Any(keywordMatch => keywordMatch.CompleteMatch);
            return match;
         }
      }

      public IKeyword GetCompletelyMatched()
      {
         KeywordMatch matched = keywordMatchList.Single(keywordMatch => keywordMatch.CompleteMatch);
         return matched.Keyword;
      }

      public bool MatchesSoFar
      {
         get
         {
            bool match = keywordMatchList.Any(keywordMatch => keywordMatch.MatchesSoFar);
            return match;
         }
      }
   }
}
