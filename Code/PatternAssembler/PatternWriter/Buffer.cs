using System.Text;

namespace PatternAssembler
{
   internal class Buffer : IBuffer
   {
      private IFunctionLibrary functionLibrary;
      private ICurrentKeyPress CurrentKey;
      private KeywordMatchService KeywordMatchService;
      private StringBuilder BufferBuilder = new StringBuilder();

      public Buffer(IFunctionLibrary functionLibrary)
      {
         this.functionLibrary = functionLibrary;
         this.CurrentKey = new CurrentKeyPress(functionLibrary);
         this.KeywordMatchService = new KeywordMatchService(functionLibrary);
      }

      public string Text
      {
         get { return this.BufferBuilder.ToString(); }
      }

      public void Clear()
      {
         this.BufferBuilder.Remove(0, BufferBuilder.Length);
         this.KeywordMatchService.Reset();
      }

      public void Next(ICurrentKeyPress currentKey)
      {
         this.CurrentKey = currentKey;
         KeywordMatchService.Next(currentKey);
         BufferBuilder.Append(currentKey.Value);
      }

      public string Flush()
      {
         string flushed = this.BufferBuilder.ToString();
         Clear();
         return flushed;
      }

      public KeywordTypeEnum KeywordPeek()
      {
         IKeyword key = KeywordMatchService.GetCompletelyMatched();
         return key.KeywordType;
      }

      public IKeyword FlushKeyword()
      {
         IKeyword flushedKeyword = KeywordMatchService.GetCompletelyMatched();
         Clear();
         return flushedKeyword;
      }

      public bool IsMatchedKeyword()
      {
         return KeywordMatchService.CompleteMatch;
      }

      public bool IsMatchedOperator()
      {
         if (!CurrentKey.IsFirstKeyPress)
         {
            if (CurrentKey.PreviousCharacterKeyFamily == KeyFamilyEnum.OperatorKey && BufferBuilder.Length == 1)
               return true;
            else
               return false;
         }
         else
            return false;
      }

      public bool IsSQLServerVariable()
      {
         return functionLibrary.IsSqlServerVariable(BufferBuilder.ToString());
      }

      public bool IsMatchedOrganisationId()
      {
         return functionLibrary.IsMatchedOrganisationId(BufferBuilder.ToString());
      }

      public bool IsTextConstant()
      {
         return functionLibrary.IsTextConstant(BufferBuilder.ToString());
      }

      public bool IsFieldOrVariable()
      {
         return functionLibrary.IsFieldOrVariable(BufferBuilder.ToString());
      }

      public bool IsNumericConstant()
      {
         return functionLibrary.IsNumericConstant(BufferBuilder.ToString());
      }
   }
}
