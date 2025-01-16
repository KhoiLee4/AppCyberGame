using AppCyberGame.Model;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCyberGame.View.Dashboard
{
    public partial class DashboardForm : Form
    {
        private CyberGameEntities _entities;
        public DashboardForm()
        {
            InitializeComponent();
            _entities = new CyberGameEntities();

            LoadDataDoanhSo();
            LoadLoaiDV();
            LoadLoaiMay();
            LoadGame();
        }

        private void LoadDataDoanhSo()
        {
            var lstDS = _entities.HOADONs.ToList();
            var lstPoint = lstDS.GroupBy(n => n.NgayGD.Date).Select(n => n.Key).ToList();

            var lPointCollection = new LPointCollection();
            foreach (var item in lstPoint)
            {
                var count = lstDS.Where(n => n.NgayGD.Date == item.Date).Count();
                if (count > 0)
                {
                    lPointCollection.Add($"{item.Day}/{item.Month}/{item.Year}", count);
                }
            }
            dataDoanhSo.DataPoints = lPointCollection;
        }
        private void LoadLoaiDV()
        {
            var lstDS = _entities.CHITIETHOADONs.ToList();
            int countGP = 0, countFood = 0, countDrink = 0;
            foreach (var item in lstDS)
            {
                var loai = _entities.DICHVUs.Where(n => n.MaDV == item.MaDV).Select(n => n.LoaiDV).FirstOrDefault();
                if (loai.Equals("Goi"))
                    countGP += item.SoLuong;
                else if (loai.Equals("DoAn"))
                    countFood += item.SoLuong;
                else if (loai.Equals("DoUong"))
                    countDrink += item.SoLuong;
            }

            var lPointCollection = new LPointCollection();
            lPointCollection.Add("Gamepass", countGP);
            lPointCollection.Add("Foods", countFood);
            lPointCollection.Add("Drinks", countDrink);

            dataLoaiDV.DataPoints = lPointCollection;
        }
        private void LoadLoaiMay()
        {
            var lstDS = _entities.MAYs.Where(n=>n.TinhTrang ==1).ToList();
            var lstPoint = lstDS.GroupBy(n => n.MaLM).Select(n => n.Key).ToList();

            var lPointCollection = new LPointCollection();
            foreach (var item in lstPoint)
            {
                var count = lstDS.Where(n => n.MaLM == item).Count();
                if (count > 0)
                {
                    lPointCollection.Add($"{_entities.LOAIMAYs.Where(n=>n.MaLM.Equals(item)).Select(n=>n.TenLM).FirstOrDefault()}", count);
                }
            }
            dataLoaiMay.DataPoints = lPointCollection;
        }
        private void LoadGame()
        {
            var lstGame = _entities.GAMEs.ToList();
            var lstPoint = lstGame.GroupBy(n => n.LoaiG).Select(n => n.Key).ToList();

            var lPointCollection = new LPointCollection();
            foreach (var item in lstPoint)
            {
                var count = lstGame.Where(n => n.LoaiG == item).Count();
                if (count > 0)
                {
                    lPointCollection.Add(item, count);
                }
            }
            dataGame.DataPoints = lPointCollection;
        }
    }
}
