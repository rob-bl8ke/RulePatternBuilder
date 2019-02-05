
using System.Collections.Generic;

namespace PatternAssembler
{
   public interface IFunctionLibrary
   {
      bool IsLiteralKey(char character);
      bool IsNegativeNumber(char previousCharacter, char currentCharacter, char nextCharacter);
      bool IsActionKey(char character);
      bool IsNonOperatorActionKey(char character);
      bool IsOperatorActionKey(char character);
      bool IsValidOperator(string textString);
      bool IsFieldOrVariableKey(char character);

      bool IsSqlServerVariable(string text);
      bool IsMatchedOrganisationId(string text);
      bool IsTextConstant(string text);
      bool IsFieldOrVariable(string text);
      bool IsNumericConstant(string text);

      List<IKeyword> AllKeywords();
   }
}
