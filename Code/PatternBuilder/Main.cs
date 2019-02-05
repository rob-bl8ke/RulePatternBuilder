using System.Windows.Forms;
using PatternAssembler;

namespace PatternBuilder
{
   public partial class Main : Form
   {
      private PatternEngine patternEngine;
      private IFunctionLibrary functionLibrary = new GenericFunctionLibrary();

      public Main()
      {
         InitializeComponent();
         patternEngine = new PatternEngine();
         optTest.Checked = true;
         getPattern();
      }

      private void txtFilter_KeyUp(object sender, KeyEventArgs e)
      {
         getPattern();
      }

      private void getPattern()
      {
         if (patternEngine != null && txtFilter.Text.Trim() != string.Empty)
         {
            if (optFilter.Checked)
               patternEngine.LoadEngine(new FilterEngine(functionLibrary));
            else if (optMeasure.Checked)
               patternEngine.LoadEngine(new MeasureEngine(functionLibrary));
            else if (optTest.Checked)
               patternEngine.LoadEngine(new TestEngine(functionLibrary));

            txtPattern.Text = patternEngine.CreatePattern(txtFilter.Text);
         }
      }
   }
}
