namespace PatternAssembler
{
   public interface IBuffer
   {
      string Text { get; }
      void Clear();
      void Next(ICurrentKeyPress currentKey);
      string Flush();
      IKeyword FlushKeyword();
      KeywordTypeEnum KeywordPeek();
      bool IsMatchedKeyword();
      bool IsMatchedOperator();
      bool IsSQLServerVariable();
      bool IsFieldOrVariable();
      bool IsMatchedOrganisationId();
      bool IsTextConstant();
      bool IsNumericConstant();
   }
}