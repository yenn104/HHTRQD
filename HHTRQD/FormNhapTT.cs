﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHTRQD
{
  public partial class FormNhapTT : Form
  {
    public FormNhapTT()
    {
      InitializeComponent();
    }

    private void btnContinue_Click(object sender, EventArgs e)
    {
      //check không null trước
      FormTieuChi form = new FormTieuChi();
      this.Hide();
      form.ShowDialog();
      this.Close();
    }
  }
}
