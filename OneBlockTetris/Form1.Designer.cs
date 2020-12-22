namespace OneBlockTetris
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
      this.blockPanel = new System.Windows.Forms.Panel();
      this.blockLabes = new System.Windows.Forms.Label[40];
      this.SuspendLayout();
      // 
      // blockPanel
      // 
      this.blockPanel.Location = new System.Drawing.Point(12, 12);
      this.blockPanel.Name = "blockPanel";
      this.blockPanel.Size = new System.Drawing.Size(350, 500);
      this.blockPanel.TabIndex = 0;

      // Create the labels
      int blockNumber = 0;
      int blockPositionX = 0;
      int blockRow = 0;
      foreach (var block in blockLabes)
      {
        blockLabes[blockNumber] = new System.Windows.Forms.Label();
        this.blockLabes[];
      }

      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(350, 500);
      this.Controls.Add(this.blockPanel);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel blockPanel;

    private System.Windows.Forms.Label[] blockLabes;
  }
}

