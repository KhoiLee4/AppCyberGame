﻿using AppCyberGame.Model;
using AppCyberGame.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGame.View.Users
{
    public partial class UsersForm : Form
    {
        private CyberGameEntities _entities;
        private List<MAY> _may;
        private List<ViewHoaDon> _viewhoadon;
        private FormAction _action;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public UsersForm()
        {
            InitializeComponent();
            //_bookSoldService = new BookSoldService();
            _action = new FormAction();
            _entities = new CyberGameEntities();
            _viewhoadon = new List<ViewHoaDon>();

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(ViewHoaDon).GetProperties().Select(prop => prop.Name).ToList();
            cbbCot.SelectedIndex = 0;

            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = true;
            }

            LoadData();
        }

        private async void LoadData()
        {
            _may = _entities.MAYs.ToList();
            _viewhoadon = new List<ViewHoaDon>();
            foreach (var item in _may)
            {
                var tk = _entities.TAIKHOANs.FirstOrDefault(x => x.MaTK == item.MaTK);
                var tenkhach = "Trống";
                if (tk != null)
                {
                    tenkhach = _entities.KHACHes.Where(n => n.MaKH == tk.MaKH).Select(n => n.TenKH).FirstOrDefault();
                }
                _viewhoadon.Add(new ViewHoaDon
                {
                    MaM = item.MaM,
                    SoMay = item.SoMay,
                    TinhTrang = item.TinhTrang > 0 ? true : false,
                    ThoiGianSD = item.ThoiGianSD,
                    TenKH = tenkhach,
                    TenLM = _entities.LOAIMAYs.Where(n => n.MaLM == item.MaLM).Select(n => n.TenLM).FirstOrDefault(),
                });
            }

            if (!string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text != "Search")
            {
                var fillterSearch = _viewhoadon.Where(n => n.MaM.Contains(txbTimKiem.Text) || n.SoMay.ToString().Contains(txbTimKiem.Text) || n.TenKH.Contains(txbTimKiem.Text) || n.TenLM.Contains(txbTimKiem.Text)).ToList();
                if (fillterSearch == null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    return;
                }
                _viewhoadon = fillterSearch;
                curentPage = 1;
            }

            var count = _viewhoadon.Count;
            countLine = int.Parse(cbbSoDong.SelectedItem.ToString());
            totalPage = (float)count / countLine;
            totalPage = totalPage > (int)totalPage ? (int)totalPage + 1 : (int)totalPage;

            if (cbbCot.SelectedItem == null)
            {
                return;
            }

            var columnName = cbbCot.SelectedItem.ToString();
            var sortOrder = cbbSapXep.SelectedItem.ToString();
            if (sortOrder == "Tăng dần")
            {
                _viewhoadon = _viewhoadon.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _viewhoadon = _viewhoadon.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns["ID"].DataPropertyName = "MaM";
            dataGridView.Columns["TimeStamp"].DataPropertyName = "SoMay";
            dataGridView.Columns["PhuongThucGD"].DataPropertyName = "TinhTrang";
            dataGridView.Columns["Price"].DataPropertyName = "ThoiGianSD";
            dataGridView.Columns["Username"].DataPropertyName = "TenKH";
            dataGridView.Columns["TenLM"].DataPropertyName = "TenLM";
            dataGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            //dataGridView.Columns["Action2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridView.Columns["Action"].Width = 100;
            //dataGridView.Columns["Action2"].Width = 100;
            dataGridView.DataSource = _viewhoadon.Skip(countLine * (curentPage - 1)).Take(countLine).ToList(); ;

            if (countLine > count)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = false;
                pnContent.Size = new Size(pnContent.Size.Width, (dataGridView.Rows[0].Height * count) + 30 + pnFooter.Size.Height);
            }
            else
            {
                if (curentPage == 1)
                {
                    btnTrangKe.Enabled = true;
                }
                pnContent.Size = new Size(pnContent.Size.Width, (dataGridView.Rows[0].Height * countLine) + 30 + pnFooter.Size.Height);
            }
            if (pnContent.Size.Height > this.Size.Height - pnHeader.Size.Height)
            {
                pnContent.Size = new Size(pnContent.Size.Width, this.Size.Height - pnHeader.Size.Height);
            }
            lblSoTrang.Text = $"{curentPage}/{totalPage}";
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (curentPage > 1)
            {
                curentPage--;
                if (!btnTrangKe.Enabled)
                {
                    btnTrangKe.Enabled = true;
                }
            }
            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
            }

            LoadData();
        }

        private void btnTrangKe_Click(object sender, EventArgs e)
        {
            if (curentPage < totalPage)
            {
                curentPage++;
                if (!btnTrangTruoc.Enabled)
                {
                    btnTrangTruoc.Enabled = true;
                }
            }
            if (curentPage == totalPage)
            {
                btnTrangKe.Enabled = false;
            }

            LoadData();
        }

        private void cbbSoDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            curentPage = 1;
            LoadData();
        }

        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            var id = row.Cells["ID"].Value.ToString();
            // Duyệt
            if (e.ColumnIndex == dataGridView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                var mayDuyet = _entities.MAYs.FirstOrDefault(n => n.MaM == id);
                if (mayDuyet != null)
                {
                    mayDuyet.TinhTrang = mayDuyet.TinhTrang > 0 ? 0 : (mayDuyet.TinhTrang == 0 ? 1 : -1);
                    mayDuyet.ThoiGianSD = 0;
                    mayDuyet.MaTK = null;
                    _entities.MAYs.AddOrUpdate(mayDuyet);
                    _entities.SaveChanges();
                    LoadData();
                }
            }
            // Chi tiết
            //if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
            //{
            //    _action.LoadDetailOrders(id);
            //}
        }

        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadData();
            }
        }

        private void txbTimKiem_Click(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "Search")
            {
                txbTimKiem.Text = string.Empty;
                txbTimKiem.ForeColor = Color.Black;
            }
        }

        private void txbTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTimKiem.Text) || txbTimKiem.Text == "Search")
            {
                txbTimKiem.Text = "Search";
                txbTimKiem.ForeColor = Color.DarkGray;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }

    public class ViewHoaDon
    {
        public string MaM { get; set; }
        public int SoMay { get; set; }
        public bool TinhTrang { get; set; }
        public Nullable<double> ThoiGianSD { get; set; }
        public string TenKH { get; set; }
        public string TenLM { get; set; }

        public ViewHoaDon() { }
    }
}
