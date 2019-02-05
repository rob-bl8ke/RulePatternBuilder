
namespace PatternAssembler
{


   public abstract class Segment
   {
      private string value = "";

      public virtual string Value
      {
         get { return this.value; }
         set { this.value = value; }
      }
      public int Ordinal { get; set; }

      public virtual string GetCode()
      {
         return "";
      }

      public Segment(string value, int ordinal)
      {
         this.Value = value;
         this.Ordinal = ordinal;
      }
   }
}
