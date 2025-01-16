using AppCyberGame.Model;
using AppCyberGame.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGame.View.Orders
{
    public partial class DetailOrdersForm : Form
    {
        private CyberGameEntities _entities;
        private List<CHITIETHOADON> _chitiethoadon;
        private List<ViewCTHD> _viewhoadon;
        private FormAction _action;
        private string _id;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public DetailOrdersForm(string id)
        {
            InitializeComponent();
            //_bookSoldService = new BookSoldService();
            _action = new FormAction();
            _entities = new CyberGameEntities();
            _viewhoadon = new List<ViewCTHD>();
            _id = id;

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
            _chitiethoadon = _entities.CHITIETHOADONs.Where(n=>n.MaHD == _id).ToList();
            _viewhoadon = new List<ViewCTHD>();
            foreach (var item in _chitiethoadon)
            {
                _viewhoadon.Add(new ViewCTHD
                {
                    MaHD = item.MaHD,
                    GhiChu = item.GhiChu,
                    SoLuong = item.SoLuong,
                    TenDV = _entities.DICHVUs.Where(n => n.MaDV == item.MaDV).Select(n => n.TenDV).FirstOrDefault()
                });
            }

            if (!string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text != "Search")
            {
                var fillterSearch = _viewhoadon.Where(n => n.MaHD.Contains(txbTimKiem.Text) || n.TenDV.Contains(txbTimKiem.Text) || n.GhiChu.Contains(txbTimKiem.Text)).ToList();
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
            dataGridView.Columns["ID"].DataPropertyName = "MaHD";
            dataGridView.Columns["TimeStamp"].DataPropertyName = "TenDV";
            dataGridView.Columns["PhuongThucGD"].DataPropertyName = "SoLuong";
            dataGridView.Columns["Price"].DataPropertyName = "GhiChu";
            //dataGridView.Columns["Username"].DataPropertyName = "TenKH";
            //dataGridView.Columns["IsCheck"].DataPropertyName = "IsCheck";
            //dataGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            //dataGridView.Columns["Action2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            //dataGridView.Columns["Action"].Width = 100;
            //dataGridView.Columns["Action2"].Width = 100;
            dataGridView.DataSource = _viewhoadon.Skip(countLine * (curentPage - 1)).Take(countLine).ToList(); ;

            if (countLine > count)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = false;
                //pnContent.Size = new Size(pnContent.Size.Width, (dataGridView.Rows[0].Height * count) + 30 + pnFooter.Size.Height);
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
                //var hoadonDuyet = _entities.HOADONs.FirstOrDefault(n => n.MaHD == id);
                //if (hoadonDuyet != null)
                //{
                //    hoadonDuyet.IsCheck = true;
                //    hoadonDuyet.MaQTV = Session.CurentUser.MaQTV;
                //    _entities.HOADONs.AddOrUpdate(hoadonDuyet);
                //    _entities.SaveChanges();
                //    LoadData();
                //}
            }
            // Chi tiết
            if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
            {
                //_action.LoadDetailOrders();
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
    public class ViewCTHD
    {
        public string MaHD { get; set; }
        public string TenDV { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
        public ViewCTHD() { }
    }
}
