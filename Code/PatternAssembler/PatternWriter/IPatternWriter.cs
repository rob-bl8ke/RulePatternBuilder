namespace PatternAssembler
{
   public interface IPatternWriter
   {
      void Clear();
      string GetPattern();
      string GetText();
      void WriteKeyword(Segment keywordSegment, ICurrentKeyPress actionKey);
      void WriteField(Segment varSegment, ICurrentKeyPress actionKey);
      void WriteTextConstant(Segment textConstantSegment, ICurrentKeyPress actionKey);
      void WriteNumericConstant(Segment numericConstantSegment, ICurrentKeyPress actionKey);
      void WriteOrganisationId(Segment orgIdSegment, ICurrentKeyPress actionKey);
      void WriteSqlServerVariable(Segment sqlVarSegment, ICurrentKeyPress actionKey);
      void WriteOperator(Segment operatorSegment, ICurrentKeyPress actionKey);
      void WriteActionKey(Segment actionSegment, ICurrentKeyPress actionKey);
   }
}