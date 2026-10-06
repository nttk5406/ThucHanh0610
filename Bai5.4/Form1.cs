using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai5_4
{
    public partial class Form1 : Form
    {
        List<NhanVien> dsNhanVien = new List<NhanVien>();

        public Form1()
        {
            InitializeComponent();

            TaoDuLieu();
            TaoCay();
            HienThiTatCa();
        }

        void TaoDuLieu()
        {
            dsNhanVien.Add(new NhanVien("NV01", "Nguyễn Trung Thành", "Nhân viên", "01/01/2026", "Kinh doanh", "Nhóm 1"));
            dsNhanVien.Add(new NhanVien("NV02", "Đỗ Xuân Nhất", "Nhân viên", "05/02/2024", "Kinh doanh", "Nhóm 1"));
            dsNhanVien.Add(new NhanVien("NV03", "Nguyễn Duy Tuấn", "Trưởng nhóm", "10/03/2025", "Kinh doanh", "Nhóm 2"));
            dsNhanVien.Add(new NhanVien("NV04", "Đặng Đức Vinh", "Nhân viên", "15/04/2022", "Kinh doanh", "Nhóm 2"));

            dsNhanVien.Add(new NhanVien("NV05", "Nguyễn Văn An", "Nhân viên", "01/01/2024", "Kỹ thuật", "Nhóm 1"));
            dsNhanVien.Add(new NhanVien("NV06", "Trần Thị Lan", "Nhân viên", "05/02/2026", "Kỹ thuật", "Nhóm 1"));
            dsNhanVien.Add(new NhanVien("NV07", "Lê Văn Hùng", "Trưởng nhóm", "10/03/2023", "Kỹ thuật", "Nhóm 2"));
            dsNhanVien.Add(new NhanVien("NV08", "Phạm Thị Mai", "Nhân viên", "15/04/2024", "Kỹ thuật", "Nhóm 2"));

            dsNhanVien.Add(new NhanVien("NV09", "Nguyễn Văn Sơn", "Nhân viên", "01/01/2026", "Nhân sự", "Nhóm 1"));
            dsNhanVien.Add(new NhanVien("NV10", "Trần Văn Long", "Nhân viên", "05/02/2026", "Nhân sự", "Nhóm 1"));
            dsNhanVien.Add(new NhanVien("NV11", "Lê Thị Hương", "Trưởng nhóm", "10/03/2023", "Nhân sự", "Nhóm 2"));
            dsNhanVien.Add(new NhanVien("NV12", "Phạm Văn Đức", "Nhân viên", "15/04/2025", "Nhân sự", "Nhóm 2"));
        }

        void TaoCay()
        {
            TreeNode congTy = new TreeNode("Công ty ABC");
            congTy.ImageIndex = 0;

            TreeNode kinhDoanh = new TreeNode("Phòng Kinh doanh");
            TreeNode kyThuat = new TreeNode("Phòng Kỹ thuật");
            TreeNode nhanSu = new TreeNode("Phòng Nhân sự");

            kinhDoanh.ImageIndex = 0;
            kyThuat.ImageIndex = 0;
            nhanSu.ImageIndex = 0;

            TreeNode kd1 = new TreeNode("Nhóm 1");
            TreeNode kd2 = new TreeNode("Nhóm 2");
            kd1.ImageIndex = 1;
            kd2.ImageIndex = 1;
            kinhDoanh.Nodes.Add(kd1);
            kinhDoanh.Nodes.Add(kd2);

            TreeNode kt1 = new TreeNode("Nhóm 1");
            TreeNode kt2 = new TreeNode("Nhóm 2");
            kt1.ImageIndex = 1;
            kt2.ImageIndex = 1;
            kyThuat.Nodes.Add(kt1);
            kyThuat.Nodes.Add(kt2);

            TreeNode ns1 = new TreeNode("Nhóm 1");
            TreeNode ns2 = new TreeNode("Nhóm 2");
            ns1.ImageIndex = 1;
            ns2.ImageIndex = 1;
            nhanSu.Nodes.Add(ns1);
            nhanSu.Nodes.Add(ns2);

            congTy.Nodes.Add(kinhDoanh);
            congTy.Nodes.Add(kyThuat);
            congTy.Nodes.Add(nhanSu);

            tvDepartments.Nodes.Add(congTy);

            congTy.Expand();
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Công ty ABC")
            {
                HienThiTatCa();
            }
            else if (e.Node.Parent != null && e.Node.Parent.Text == "Công ty ABC")
            {
                string phongBan = e.Node.Text.Replace("Phòng ", "");
                HienThiTheoPhong(phongBan);
            }
            else
            {
                string phongBan = e.Node.Parent.Text.Replace("Phòng ", "");
                string nhom = e.Node.Text;

                HienThiTheoNhom(phongBan, nhom);
            }
        }

        void HienThiTatCa()
        {
            lsvEmployees.Items.Clear();

            foreach (NhanVien nv in dsNhanVien)
            {
                ThemNhanVien(nv);
            }
        }

        void HienThiTheoPhong(string phongBan)
        {
            lsvEmployees.Items.Clear();

            foreach (NhanVien nv in dsNhanVien)
            {
                if (nv.PhongBan == phongBan)
                {
                    ThemNhanVien(nv);
                }
            }
        }

        void HienThiTheoNhom(string phongBan, string nhom)
        {
            lsvEmployees.Items.Clear();

            foreach (NhanVien nv in dsNhanVien)
            {
                if (nv.PhongBan == phongBan && nv.Nhom == nhom)
                {
                    ThemNhanVien(nv);
                }
            }
        }

        void ThemNhanVien(NhanVien nv)
        {
            ListViewItem item = new ListViewItem(nv.MaNV);
            item.SubItems.Add(nv.HoTen);
            item.SubItems.Add(nv.ChucVu);
            item.SubItems.Add(nv.NgayVaoLam);

            lsvEmployees.Items.Add(item);
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboView.SelectedIndex == 0)
                lsvEmployees.View = View.Details;
            else if (cboView.SelectedIndex == 1)
                lsvEmployees.View = View.SmallIcon;
            else if (cboView.SelectedIndex == 2)
                lsvEmployees.View = View.LargeIcon;
            else if (cboView.SelectedIndex == 3)
                lsvEmployees.View = View.Tile;
        }
    }

    class NhanVien
    {
        public string MaNV;
        public string HoTen;
        public string ChucVu;
        public string NgayVaoLam;
        public string PhongBan;
        public string Nhom;

        public NhanVien(string maNV, string hoTen, string chucVu, string ngayVaoLam, string phongBan, string nhom)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ChucVu = chucVu;
            NgayVaoLam = ngayVaoLam;
            PhongBan = phongBan;
            Nhom = nhom;
        }
    }
}