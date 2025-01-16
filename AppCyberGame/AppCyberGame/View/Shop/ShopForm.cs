using AppCyberGame.Model;
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

namespace AppCyberGame.View.Shop
{
    public partial class ShopForm : Form
    {
        private CyberGameEntities _entities;
        private List<DICHVU> _hoadon;
        private List<ViewHoaDon> _viewhoadon;
        private FormAction _action;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public ShopForm()
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
            //_hoadon = _entities.HOADONs.ToList();
            //if (string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text == "Search")
            //{
            _hoadon = _entities.DICHVUs.Where(n => n.SoTonKho >= 0).ToList();
            //_viewhoadon = new List<ViewHoaDon>();
            //foreach (var item in _hoadon)
            //{
            //    var tk = _entities.TAIKHOANs.FirstOrDefault(x => x.MaTK == item.MaTK);
            //    _viewhoadon.Add(new ViewHoaDon
            //    {
            //        MaHD = item.MaHD,
            //        NgayGD = item.NgayGD,
            //        PhuongThucGD = item.PhuongThucGD,
            //        TongTien = item.TongTien,
            //        TenKH = _entities.KHACHes.Where(n => n.MaKH == tk.MaKH).Select(n => n.TenKH).FirstOrDefault(),
            //        IsCheck = item.IsCheck
            //    });
            //}
            //}

            if (!string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text != "Search")
            {
                var fillterSearch = _hoadon.Where(n => n.MaDV.Contains(txbTimKiem.Text) || n.TenDV.Contains(txbTimKiem.Text) || n.LoaiDV.Contains(txbTimKiem.Text) || n.MoTaDV.Contains(txbTimKiem.Text)).ToList();
                if (fillterSearch == null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    return;
                }
                _hoadon = fillterSearch;
                curentPage = 1;
            }

            var count = _hoadon.Count;
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
                _hoadon = _hoadon.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _hoadon = _hoadon.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns["ID"].DataPropertyName = "MaDV";
            dataGridView.Columns["TimeStamp"].DataPropertyName = "TenDV";
            dataGridView.Columns["PhuongThucGD"].DataPropertyName = "GiaDV";
            dataGridView.Columns["Price"].DataPropertyName = "LoaiDV";
            dataGridView.Columns["Username"].DataPropertyName = "SoTonKho";
            dataGridView.Columns["IsCheck"].DataPropertyName = "MoTaDV";
            dataGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridView.Columns["Action2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridView.Columns["Action"].Width = 100;
            dataGridView.Columns["Action2"].Width = 100;
            dataGridView.DataSource = _hoadon.Skip(countLine * (curentPage - 1)).Take(countLine).ToList(); ;

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
                var hoadonDuyet = _entities.DICHVUs.FirstOrDefault(n => n.MaDV == id);
                if (hoadonDuyet != null)
                {
                    pnUpdate.Visible = true;
                    btnCreate1.Visible = false;
                    txbMaDV.Text = hoadonDuyet.MaDV;
                    txbTenDV.Text = hoadonDuyet.TenDV;
                    txbGiaDv.Text = hoadonDuyet.GiaDV.ToString();
                    txbLoaiDV.Text = hoadonDuyet.LoaiDV;
                    txbHinhAnh.Text = hoadonDuyet.HinhAnh;
                    txbSoLuong.Text = hoadonDuyet.SoTonKho.ToString();
                    txbMoTa.Text = hoadonDuyet.MoTaDV ?? " ";

                }
            }
            // Chi tiết
            if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
            {
                var hoadonDuyet = _entities.DICHVUs.FirstOrDefault(n => n.MaDV == id);
                hoadonDuyet.SoTonKho = -1;
                _entities.DICHVUs.AddOrUpdate(hoadonDuyet);
                _entities.SaveChanges();
                LoadData();
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var dv = new DICHVU
            {
                MaDV = txbMaDV.Text,
                TenDV = txbTenDV.Text,
                GiaDV = double.Parse(txbGiaDv.Text),
                LoaiDV = txbLoaiDV.Text,
                MoTaDV = txbMoTa.Text,
                HinhAnh = txbHinhAnh.Text,
                SoTonKho = int.Parse(txbSoLuong.Text)
            };

            _entities.DICHVUs.AddOrUpdate(dv);
            _entities.SaveChanges();
            pnUpdate.Visible = false;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            pnUpdate.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            pnUpdate.Visible = true;
            btnCreate1.Visible = true;

            txbMaDV.Text = string.Empty;
            txbTenDV.Text = string.Empty;
            txbGiaDv.Text = string.Empty;
            txbLoaiDV.Text = string.Empty;
            txbHinhAnh.Text = string.Empty;
            txbSoLuong.Text = string.Empty;
            txbMoTa.Text = string.Empty;
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            var dv = new DICHVU
            {
                MaDV = txbMaDV.Text,
                TenDV = txbTenDV.Text,
                GiaDV = double.Parse(txbGiaDv.Text),
                LoaiDV = txbLoaiDV.Text,
                MoTaDV = txbMoTa.Text,
                HinhAnh = txbHinhAnh.Text,
                SoTonKho = int.Parse(txbSoLuong.Text)
            };

            _entities.DICHVUs.AddOrUpdate(dv);
            _entities.SaveChanges();
            pnUpdate.Visible = false;
            btnCreate1.Visible = false;
        }
    }

    public class ViewHoaDon
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public double GiaDV { get; set; }
        public string LoaiDV { get; set; }
        public string MoTaDV { get; set; }
        public string HinhAnh { get; set; }
        public int SoTonKho { get; set; }

        public ViewHoaDon() { }
    }
}
