using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        #region sự kiện mở các form
        private void barDanhMucChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyChucVu quanlychucvu = new FrmQuanLyChucVu();
            quanlychucvu.TopLevel = false;
            quanlychucvu.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(quanlychucvu);
            quanlychucvu.Show();
        }

        private void barDanhMucPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyPhongBan frmtg = new FrmQuanLyPhongBan();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barQuanLyNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyNhanVien frmtg = new FrmQuanLyNhanVien();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barHopDongLaoDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHopDongLaoDong frmtg = new FrmHopDongLaoDong();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barQuaTrinhCongTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuaTrinhCongTac frmtg = new FrmQuaTrinhCongTac();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongTinKhenThuongKiLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKhenThuongKiLuat frmtg = new FrmKhenThuongKiLuat();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barThongKeTheoNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongKeNhanVienTheoPhongBan frmtg = new FrmThongKeNhanVienTheoPhongBan();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUser frmtg = new FrmUser();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        #endregion

        private void barQuanLyNhanVien_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FrmQuanLyNhanVien frmtg = new FrmQuanLyNhanVien();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barQuaTrinhCongTac_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FrmQuaTrinhCongTac frmtg = new FrmQuaTrinhCongTac();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barHopDongLaoDong_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FrmHopDongLaoDong frmtg = new FrmHopDongLaoDong();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmKhenThuongKiLuat frmtg = new FrmKhenThuongKiLuat();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUser frmtg = new FrmUser();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmThongKeNhanVienTheoPhongBan frmtg = new FrmThongKeNhanVienTheoPhongBan();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQuanLyChucVu quanlychucvu = new FrmQuanLyChucVu();
            quanlychucvu.TopLevel = false;
            quanlychucvu.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(quanlychucvu);
            quanlychucvu.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQuanLyPhongBan frmtg = new FrmQuanLyPhongBan();
            frmtg.TopLevel = false;
            frmtg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmtg);
            frmtg.Show();
        }
    }
}
