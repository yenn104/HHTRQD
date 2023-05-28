
namespace HHTRQD
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
      this.label1 = new System.Windows.Forms.Label();
      this.gvTrongSo = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.gvTrongSo)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Cambria", 20F);
      this.label1.Location = new System.Drawing.Point(305, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(258, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "Trọng số tiêu chí";
      // 
      // gvTrongSo
      // 
      this.gvTrongSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvTrongSo.Location = new System.Drawing.Point(93, 112);
      this.gvTrongSo.Name = "gvTrongSo";
      this.gvTrongSo.RowHeadersWidth = 51;
      this.gvTrongSo.RowTemplate.Height = 24;
      this.gvTrongSo.Size = new System.Drawing.Size(715, 324);
      this.gvTrongSo.TabIndex = 1;
      this.gvTrongSo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvTrongSo_CellFormatting);
      this.gvTrongSo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTrongSo_CellValueChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(911, 489);
      this.Controls.Add(this.gvTrongSo);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.gvTrongSo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView gvTrongSo;
  }
}