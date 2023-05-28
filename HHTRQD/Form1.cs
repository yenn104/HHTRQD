using HHTRQD.Models;
using HHTRQD.Models.Entities;
using System;
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
  public partial class Form1 : Form
  {
    List<TChi> listTC;
    public Form1(List<TChi> listTC)
    {
      this.listTC = listTC;
      InitializeComponent();
      LoadMaTrix(listTC);
      gvTrongSo.CellFormatting += gvTrongSo_CellFormatting;
      //gvTrongSo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
    }

    private void gvTrongSo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int columnIndex = e.ColumnIndex;

      if (rowIndex == columnIndex)
      {
        e.CellStyle.BackColor = Color.LightBlue;
      }
    
  }

    private void LoadMaTrix(List<TChi> listTC)
    {
      gvTrongSo.Columns.Clear();

      for (int i = 0; i < listTC.Count; i++)
      {
        string columnName = $"Column{i + 1}";
        DataGridViewColumn column = new DataGridViewTextBoxColumn
        {
          Name = columnName,
          HeaderText = listTC[i].TenTC,
          DataPropertyName = columnName
        };
        gvTrongSo.Columns.Add(column);
      }

      gvTrongSo.Rows.Clear();

      int rowCount = listTC.Count;
      for (int i = 0; i < rowCount; i++)
      {
        DataGridViewRow row = new DataGridViewRow();
        row.CreateCells(gvTrongSo);
        for (int j = 0; j < rowCount; j++)
        {
          if (i == j)
          {
            row.Cells[j].Value = 1;
            row.Cells[j].ReadOnly = true;
          }
          else
          {
            row.Cells[j].Value = DBNull.Value;
          }
        }

        gvTrongSo.Rows.Add(row);
        gvTrongSo.Rows[i].HeaderCell.Value = listTC[i].TenTC;
      }


    }

    private void gvTrongSo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      int rowIndex = e.RowIndex;
      int columnIndex = e.ColumnIndex;

      // Kiểm tra chỉ thực hiện cập nhật giá trị đối diện khi thay đổi giá trị ở các ô phía trên đường chéo
      if (columnIndex > rowIndex)
      {
        var currentCell = gvTrongSo.Rows[rowIndex].Cells[columnIndex];

        if (double.TryParse(currentCell.Value?.ToString(), out double currentValue))
        {
          var oppositeCell = gvTrongSo.Rows[columnIndex].Cells[rowIndex];
          oppositeCell.Value = Math.Round(1 / currentValue, 4);
        }
      }

    }


  }
}
