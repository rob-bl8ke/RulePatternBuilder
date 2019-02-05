namespace PatternAssembler
{
   public interface ICurrentKeyPress
   {
      KeyFamilyEnum KeyFamily { get; }
      char UppercaseValue { get; }
      char Value { get; }
      char NextValue { get; }
      KeyFamilyEnum NextCharacterKeyFamily { get; }
      char PreviousValue { get; }
      KeyFamilyEnum PreviousCharacterKeyFamily { get; }
      bool IsFirstKeyPress { get; }
      int Position { get; }
      bool ProcessingRequired();
      void Reset();
      KeyFamilyEnum Next(char character, char nextCharacter);
   }
}