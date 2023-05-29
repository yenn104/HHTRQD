
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
      this.btnTinhAHP = new System.Windows.Forms.Button();
      this.gvKetqua = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSaveDatabase = new System.Windows.Forms.Button();
      this.btnGoBack = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gvTrongSo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvKetqua)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Cambria", 20F);
      this.label1.Location = new System.Drawing.Point(533, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(258, 40);
      this.label1.TabIndex = 0;
      this.label1.Text = "Trọng số tiêu chí";
      // 
      // gvTrongSo
      // 
      this.gvTrongSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvTrongSo.Location = new System.Drawing.Point(28, 78);
      this.gvTrongSo.Name = "gvTrongSo";
      this.gvTrongSo.RowHeadersWidth = 51;
      this.gvTrongSo.RowTemplate.Height = 24;
      this.gvTrongSo.Size = new System.Drawing.Size(1258, 251);
      this.gvTrongSo.TabIndex = 1;
      this.gvTrongSo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvTrongSo_CellFormatting);
      this.gvTrongSo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTrongSo_CellValueChanged);
      // 
      // btnTinhAHP
      // 
      this.btnTinhAHP.Location = new System.Drawing.Point(28, 347);
      this.btnTinhAHP.Name = "btnTinhAHP";
      this.btnTinhAHP.Size = new System.Drawing.Size(101, 26);
      this.btnTinhAHP.TabIndex = 2;
      this.btnTinhAHP.Text = "Tính AHP";
      this.btnTinhAHP.UseVisualStyleBackColor = true;
      // 
      // gvKetqua
      // 
      this.gvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvKetqua.Location = new System.Drawing.Point(28, 427);
      this.gvKetqua.Name = "gvKetqua";
      this.gvKetqua.RowHeadersWidth = 51;
      this.gvKetqua.RowTemplate.Height = 24;
      this.gvKetqua.Size = new System.Drawing.Size(1258, 251);
      this.gvKetqua.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(28, 392);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 16);
      this.label2.TabIndex = 4;
      this.label2.Text = "Kết quả:";
      // 
      // btnSaveDatabase
      // 
      this.btnSaveDatabase.Location = new System.Drawing.Point(1185, 383);
      this.btnSaveDatabase.Name = "btnSaveDatabase";
      this.btnSaveDatabase.Size = new System.Drawing.Size(101, 30);
      this.btnSaveDatabase.TabIndex = 5;
      this.btnSaveDatabase.Text = "Lưu kết quả";
      this.btnSaveDatabase.UseVisualStyleBackColor = true;
      // 
      // btnGoBack
      // 
      this.btnGoBack.Location = new System.Drawing.Point(1185, 684);
      this.btnGoBack.Name = "btnGoBack";
      this.btnGoBack.Size = new System.Drawing.Size(101, 30);
      this.btnGoBack.TabIndex = 6;
      this.btnGoBack.Text = "Trở về";
      this.btnGoBack.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(1318, 735);
      this.Controls.Add(this.btnGoBack);
      this.Controls.Add(this.btnSaveDatabase);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.gvKetqua);
      this.Controls.Add(this.btnTinhAHP);
      this.Controls.Add(this.gvTrongSo);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.gvTrongSo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvKetqua)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView gvTrongSo;
    private System.Windows.Forms.Button btnTinhAHP;
    private System.Windows.Forms.DataGridView gvKetqua;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSaveDatabase;
    private System.Windows.Forms.Button btnGoBack;
  }
}