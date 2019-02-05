using System;

namespace PatternAssembler
{
   public enum KeyFamilyEnum
   {
      Nothing,
      ActionKey,
      OperatorKey,
      LiteralStartEndKey,
      FieldOrVariableKey
   }

   internal class CurrentKeyPress : ICurrentKeyPress
   {
      private int position = -1;
      private char currentCharacter = '\0';
      private char previousCharacter = '\0';
      private char nextCharacter = '\0';
      private LiteralStatus literalStatus = new LiteralStatus();
      protected IFunctionLibrary functionLibrary;

      public CurrentKeyPress(IFunctionLibrary functionLibrary)
      {
         this.functionLibrary = functionLibrary;
      }
      public KeyFamilyEnum KeyFamily
      {
         get { return getKeyFamily(this.currentCharacter); }
      }

      public void Reset()
      {
         literalStatus.Reset();
         position = -1;
         currentCharacter = '\0';
         previousCharacter = '\0';
         nextCharacter = '\0';
      }

      public char UppercaseValue
      {
         get { return char.ToUpper(this.Value); }
      }

      public char Value
      {
         get { return this.currentCharacter; }
      }

      public char NextValue
      {
         get { return this.nextCharacter; }
      }

      public KeyFamilyEnum NextCharacterKeyFamily
      {
         get { return getKeyFamily(this.nextCharacter); }
      }

      public char PreviousValue
      {
         get { return this.previousCharacter; }
      }

      public KeyFamilyEnum PreviousCharacterKeyFamily
      {
         get { return getKeyFamily(this.previousCharacter); }
      }

      public bool IsFirstKeyPress
      {
         get { return previousCharacter == '\0'; }
      }

      public bool ProcessingRequired()
      {

         //if (ComponentActionLibrary.IsActionKey(currentCharacter) && !literalStatus.WithinLiteralString)
         //{
         //   if (!ComponentActionLibrary.IsNegativeNumber(previousCharacter, currentCharacter, nextCharacter))
         //      return true;
         //}

         if (functionLibrary.IsActionKey(currentCharacter) && !literalStatus.WithinLiteralString)
         {
            if (!functionLibrary.IsNegativeNumber(previousCharacter, currentCharacter, nextCharacter))
               return true;
         }
         return false;
      }

      public int Position
      {
         get { return this.position; }
      }

      public KeyFamilyEnum Next(char character, char nextCharacter)
      {
         position++;
         this.previousCharacter = currentCharacter;
         this.currentCharacter = character;
         this.nextCharacter = nextCharacter;
         literalStatus.Next(this);

         return getKeyFamily(character);
      }

      private KeyFamilyEnum getKeyFamily(char character)
      {
         KeyFamilyEnum charKeyFamily = KeyFamilyEnum.Nothing;

         if (functionLibrary.IsNonOperatorActionKey(character))
            charKeyFamily = KeyFamilyEnum.ActionKey;

         else if (functionLibrary.IsOperatorActionKey(character))
            charKeyFamily = KeyFamilyEnum.OperatorKey;

         else if (functionLibrary.IsFieldOrVariableKey(character))
            charKeyFamily = KeyFamilyEnum.FieldOrVariableKey;

         else if (functionLibrary.IsLiteralKey(character))
            charKeyFamily = KeyFamilyEnum.LiteralStartEndKey;

         else
            charKeyFamily = KeyFamilyEnum.Nothing;

         return charKeyFamily;
      }
   }
}
