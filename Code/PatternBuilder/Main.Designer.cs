namespace PatternBuilder
{
   partial class Main
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.optMeasure = new System.Windows.Forms.RadioButton();
            this.optFilter = new System.Windows.Forms.RadioButton();
            this.optTest = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // optMeasure
            // 
            this.optMeasure.AutoSize = true;
            this.optMeasure.Location = new System.Drawing.Point(15, 6);
            this.optMeasure.Name = "optMeasure";
            this.optMeasure.Size = new System.Drawing.Size(66, 17);
            this.optMeasure.TabIndex = 9;
            this.optMeasure.TabStop = true;
            this.optMeasure.Text = "Measure";
            this.optMeasure.UseVisualStyleBackColor = true;
            // 
            // optFilter
            // 
            this.optFilter.AutoSize = true;
            this.optFilter.Location = new System.Drawing.Point(88, 6);
            this.optFilter.Name = "optFilter";
            this.optFilter.Size = new System.Drawing.Size(47, 17);
            this.optFilter.TabIndex = 10;
            this.optFilter.TabStop = true;
            this.optFilter.Text = "Filter";
            this.optFilter.UseVisualStyleBackColor = true;
            // 
            // optTest
            // 
            this.optTest.AutoSize = true;
            this.optTest.Location = new System.Drawing.Point(141, 6);
            this.optTest.Name = "optTest";
            this.optTest.Size = new System.Drawing.Size(83, 17);
            this.optTest.TabIndex = 13;
            this.optTest.TabStop = true;
            this.optTest.Text = "Test Pattern";
            this.optTest.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(5, 29);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtFilter);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtPattern);
            this.splitContainer2.Size = new System.Drawing.Size(677, 488);
            this.splitContainer2.SplitterDistance = 219;
            this.splitContainer2.TabIndex = 14;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(677, 219);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyUp);
            // 
            // txtPattern
            // 
            this.txtPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPattern.Enabled = false;
            this.txtPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPattern.Location = new System.Drawing.Point(0, 0);
            this.txtPattern.Multiline = true;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(677, 265);
            this.txtPattern.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 523);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.optTest);
            this.Controls.Add(this.optFilter);
            this.Controls.Add(this.optMeasure);
            this.Name = "Main";
            this.Text = "Rule Patterns Test Drive";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.RadioButton optMeasure;
      private System.Windows.Forms.RadioButton optFilter;
      private System.Windows.Forms.RadioButton optTest;
      private System.Windows.Forms.SplitContainer splitContainer2;
      private System.Windows.Forms.TextBox txtFilter;
      private System.Windows.Forms.TextBox txtPattern;
   }
}

