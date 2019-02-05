
using System.Text;
using System.Collections.Generic;
namespace PatternAssembler
{
   internal class PatternWriter : IPatternWriter
   {
      private int operatorIncrementor = 0;
      private IFunctionLibrary functionLibrary;
      private List<Segment> patternSegments = new List<Segment>();

      public PatternWriter(IFunctionLibrary functionLibrary)
      {
         this.functionLibrary = functionLibrary;
      }

      public void Clear()
      {
         operatorIncrementor = 0;
         patternSegments.Clear();
      }

      public string GetPattern()
      {
         StringBuilder builder = new StringBuilder();

         foreach (Segment segment in patternSegments)
            builder.Append(segment.GetCode());

         return builder.ToString();
      }

      public string GetText()
      {
         StringBuilder builder = new StringBuilder();

         foreach (Segment segment in patternSegments)
            builder.Append(segment.Value);

         return builder.ToString();
      }

      public void WriteKeyword(Segment keywordSegment, ICurrentKeyPress actionKey)
      {
         patternSegments.Add(keywordSegment);
      }

      public void WriteField(Segment varSegment, ICurrentKeyPress actionKey)
      {
         if (varSegment.Value.Trim() != string.Empty)
            patternSegments.Add(varSegment);
      }

      public void WriteTextConstant(Segment textConstantSegment, ICurrentKeyPress actionKey)
      {
         if (textConstantSegment.Value.Trim() != string.Empty)
            patternSegments.Add(textConstantSegment);
      }

      public void WriteNumericConstant(Segment numericConstantSegment, ICurrentKeyPress actionKey)
      {
         if (numericConstantSegment.Value.Trim() != string.Empty)
            patternSegments.Add(numericConstantSegment);
      }

      public void WriteOrganisationId(Segment orgIdSegment, ICurrentKeyPress actionKey)
      {
         if (orgIdSegment.Value.Trim() != string.Empty)
            patternSegments.Add(orgIdSegment);
      }

      public void WriteSqlServerVariable(Segment sqlVarSegment, ICurrentKeyPress actionKey)
      {
         if (sqlVarSegment.Value.Trim() != string.Empty)
            patternSegments.Add(sqlVarSegment);
      }

      public void WriteVariable(Segment variableSegment, ICurrentKeyPress actionKey)
      {
         if (variableSegment.Value.Trim() != string.Empty)
            patternSegments.Add(variableSegment);
      }

      public void WriteOperator(Segment operatorSegment, ICurrentKeyPress actionKey)
      {
         if (patternSegments.Count >= 1)
         {
            string combineTest = "";
            combineTest = patternSegments[patternSegments.Count - 1].Value + actionKey.Value.ToString();

            // check for operators consisting of more than 1 character (<>, !=, etc.)
            
            if (functionLibrary.IsValidOperator(combineTest))
            {
               patternSegments[patternSegments.Count - 1].Value = combineTest;
               return;
            }
         }

         patternSegments.Add(operatorSegment);
      }

      public void WriteActionKey(Segment actionSegment, ICurrentKeyPress actionKey)
      {
         patternSegments.Add(actionSegment);
      }
   }
}
