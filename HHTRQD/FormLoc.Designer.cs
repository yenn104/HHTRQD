﻿
namespace HHTRQD
{
  partial class FormLoc
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnThoat = new System.Windows.Forms.Button();
      this.btnTieptuc = new System.Windows.Forms.Button();
      this.lvTieuChi = new System.Windows.Forms.ListView();
      this.lvNganh = new System.Windows.Forms.ListView();
      this.label2 = new System.Windows.Forms.Label();
      this.cbbChonTieuChi = new System.Windows.Forms.ComboBox();
      this.label12 = new System.Windows.Forms.Label();
      this.cbbChonNganh = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnThoat);
      this.panel1.Controls.Add(this.btnTieptuc);
      this.panel1.Controls.Add(this.lvTieuChi);
      this.panel1.Controls.Add(this.lvNganh);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.cbbChonTieuChi);
      this.panel1.Controls.Add(this.label12);
      this.panel1.Controls.Add(this.cbbChonNganh);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Font = new System.Drawing.Font("Cambria", 20F);
      this.panel1.Location = new System.Drawing.Point(0, 84);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1278, 537);
      this.panel1.TabIndex = 0;
      // 
      // btnThoat
      // 
      this.btnThoat.Font = new System.Drawing.Font("Cambria", 13F);
      this.btnThoat.Location = new System.Drawing.Point(127, 443);
      this.btnThoat.Name = "btnThoat";
      this.btnThoat.Size = new System.Drawing.Size(159, 48);
      this.btnThoat.TabIndex = 25;
      this.btnThoat.Text = "Thoát";
      this.btnThoat.UseVisualStyleBackColor = true;
      // 
      // btnTieptuc
      // 
      this.btnTieptuc.Font = new System.Drawing.Font("Cambria", 13F);
      this.btnTieptuc.Location = new System.Drawing.Point(981, 443);
      this.btnTieptuc.Name = "btnTieptuc";
      this.btnTieptuc.Size = new System.Drawing.Size(159, 48);
      this.btnTieptuc.TabIndex = 24;
      this.btnTieptuc.Text = "Tiếp tục";
      this.btnTieptuc.UseVisualStyleBackColor = true;
      this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
      // 
      // lvTieuChi
      // 
      this.lvTieuChi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lvTieuChi.HideSelection = false;
      this.lvTieuChi.Location = new System.Drawing.Point(806, 143);
      this.lvTieuChi.Name = "lvTieuChi";
      this.lvTieuChi.Size = new System.Drawing.Size(334, 251);
      this.lvTieuChi.TabIndex = 23;
      this.lvTieuChi.UseCompatibleStateImageBehavior = false;
      this.lvTieuChi.View = System.Windows.Forms.View.List;
      // 
      // lvNganh
      // 
      this.lvNganh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lvNganh.HideSelection = false;
      this.lvNganh.Location = new System.Drawing.Point(127, 143);
      this.lvNganh.Name = "lvNganh";
      this.lvNganh.Size = new System.Drawing.Size(584, 251);
      this.lvNganh.TabIndex = 22;
      this.lvNganh.UseCompatibleStateImageBehavior = false;
      this.lvNganh.View = System.Windows.Forms.View.List;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Cambria", 13F);
      this.label2.Location = new System.Drawing.Point(802, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(134, 26);
      this.label2.TabIndex = 21;
      this.label2.Text = "Chọn tiêu chí";
      // 
      // cbbChonTieuChi
      // 
      this.cbbChonTieuChi.Font = new System.Drawing.Font("Cambria", 13F);
      this.cbbChonTieuChi.FormattingEnabled = true;
      this.cbbChonTieuChi.Location = new System.Drawing.Point(806, 90);
      this.cbbChonTieuChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cbbChonTieuChi.Name = "cbbChonTieuChi";
      this.cbbChonTieuChi.Size = new System.Drawing.Size(334, 34);
      this.cbbChonTieuChi.TabIndex = 20;
      this.cbbChonTieuChi.SelectedIndexChanged += new System.EventHandler(this.cbbChonTieuChi_SelectedIndexChanged);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Cambria", 13F);
      this.label12.Location = new System.Drawing.Point(123, 47);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(356, 26);
      this.label12.TabIndex = 19;
      this.label12.Text = "Chọn ngành nghề phân vân (tối đa 5)";
      // 
      // cbbChonNganh
      // 
      this.cbbChonNganh.Font = new System.Drawing.Font("Cambria", 13F);
      this.cbbChonNganh.FormattingEnabled = true;
      this.cbbChonNganh.Location = new System.Drawing.Point(127, 89);
      this.cbbChonNganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cbbChonNganh.Name = "cbbChonNganh";
      this.cbbChonNganh.Size = new System.Drawing.Size(584, 34);
      this.cbbChonNganh.TabIndex = 18;
      this.cbbChonNganh.SelectedIndexChanged += new System.EventHandler(this.cbbChonNganh_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Cambria", 20F);
      this.label1.Location = new System.Drawing.Point(144, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(963, 40);
      this.label1.TabIndex = 1;
      this.label1.Text = "Phần Mềm Hỗ Trợ Tư Vấn Định Hướng Nghề Nghiệp Cho Học Sinh";
      // 
      // FormLoc
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1278, 621);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Name = "FormLoc";
      this.Text = "FormLoc";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox cbbChonNganh;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbbChonTieuChi;
    private System.Windows.Forms.ListView lvNganh;
    private System.Windows.Forms.ListView lvTieuChi;
    private System.Windows.Forms.Button btnThoat;
    private System.Windows.Forms.Button btnTieptuc;
  }
}