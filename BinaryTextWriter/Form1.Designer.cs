namespace BinaryTextWriter
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.txtText = new System.Windows.Forms.TextBox();
      this.txtBinary = new System.Windows.Forms.TextBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtText
      // 
      this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtText.Location = new System.Drawing.Point(0, 0);
      this.txtText.Multiline = true;
      this.txtText.Name = "txtText";
      this.txtText.Size = new System.Drawing.Size(422, 171);
      this.txtText.TabIndex = 0;
      this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
      // 
      // txtBinary
      // 
      this.txtBinary.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtBinary.Location = new System.Drawing.Point(0, 0);
      this.txtBinary.Multiline = true;
      this.txtBinary.Name = "txtBinary";
      this.txtBinary.Size = new System.Drawing.Size(422, 167);
      this.txtBinary.TabIndex = 1;
      this.txtBinary.TextChanged += new System.EventHandler(this.txtBinary_TextChanged);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(-3, -2);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.txtText);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.txtBinary);
      this.splitContainer1.Size = new System.Drawing.Size(422, 342);
      this.splitContainer1.SplitterDistance = 171;
      this.splitContainer1.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(419, 340);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtText;
    private System.Windows.Forms.TextBox txtBinary;
    private System.Windows.Forms.SplitContainer splitContainer1;
  }
}

