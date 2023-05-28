using HHTRQD.Models;
using HHTRQD.Models.Entities;
using Newtonsoft.Json.Linq;
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
  public partial class FormLoc : Form
  {
    private List<Nghe> listNghe = new List<Nghe>();
    private List<TChi> listTC = new List<TChi>();
    int coutNganh = 0;
    int coutTC = 0;
    public FormLoc()
    {
      InitializeComponent();
      LoadNganhData();
      LoadTieuChiData();
    }


    private void LoadNganhData()
    {
      using (var context = new HTRQDContext())
      {
        var nganhs = context.NgheNghiep.ToList();

        cbbChonNganh.Items.Clear();

        foreach (var nganh in nganhs)
        {
          Nghe nganh1 = new Nghe(nganh.Id, nganh.TenNn);
          cbbChonNganh.Items.Add(nganh1);
        }
      }
    }


    private void LoadTieuChiData()
    {
      using (var context = new HTRQDContext())
      {
        var tieuChis = context.TieuChi.ToList();

        cbbChonTieuChi.Items.Clear();

        foreach (var tieuChi in tieuChis)
        {
          TChi tieuChi1 = new TChi(tieuChi.Id, tieuChi.TenTc);

          cbbChonTieuChi.Items.Add(tieuChi1);
        }
      }
    }

    //private void cbbChonNganh_TextChanged(object sender, EventArgs e)
    //{
    //  string keyword = cbbChonNganh.Text.ToLower();

    //  // Lặp qua từng mục trong ComboBox và ẩn/mở hiển thị tùy theo từ khóa tìm kiếm
    //  for (int i = 0; i < cbbChonNganh.Items.Count; i++)
    //  {
    //    string item = cbbChonNganh.Items[i].ToString().ToLower();
    //    if (item.Contains(keyword))
    //    {
    //      cbbChonNganh.Items[i] = cbbChonNganh.Items[i].ToString();
    //    }
    //    else
    //    {
    //      cbbChonNganh.Items[i] = null;
    //    }
    //  }

    //  // Chọn lại mục đầu tiên trong ComboBox (nếu có)
    //  if (cbbChonNganh.Items.Count > 0)
    //  {
    //    cbbChonNganh.SelectedIndex = 0;
    //    cbbChonNganh.DroppedDown = true;
    //  }
    //}


    private void btnTieptuc_Click(object sender, EventArgs e)
    {
      this.Hide();
      new Form1(listTC).ShowDialog();
      this.Close();
    }

    private void cbbChonNganh_SelectedIndexChanged(object sender, EventArgs e)
    {
      Nghe selectedNghe = (Nghe)cbbChonNganh.SelectedItem;
      if (selectedNghe != null)
      {
        coutNganh++;
        cbbChonNganh.Items.Remove(selectedNghe);
        string tenNghe = selectedNghe.TenNN;
        listNghe.Add(selectedNghe);
        lvNganh.Items.Add(tenNghe);

        if (coutNganh >= 5)
        {
          cbbChonNganh.Enabled = false;
        }
      }

      

    }

    private void cbbChonTieuChi_SelectedIndexChanged(object sender, EventArgs e)
    {
      TChi selectedTieuChi = (TChi)cbbChonTieuChi.SelectedItem;
      if (selectedTieuChi != null)
      {
        coutTC++;
        cbbChonTieuChi.Items.Remove(selectedTieuChi);
        string tenTC = selectedTieuChi.TenTC;
        listTC.Add(selectedTieuChi);
        lvTieuChi.Items.Add(tenTC);

        if (coutTC >= 5)
        {
          cbbChonTieuChi.Enabled = false;
        }
      }



    }
  }
}
